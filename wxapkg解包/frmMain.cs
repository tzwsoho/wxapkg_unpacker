using System;
using System.IO;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using JSBeautifyLib;

namespace wxapkg解包
{
    public partial class frmMain : Form
    {
        #region WXAPKG 文件结构

        [StructLayout(LayoutKind.Explicit)]
        private class WXAPKG_HEADER
        {
            [MarshalAs(UnmanagedType.U1), FieldOffset(0)]
            internal byte m_first_mark;
            [MarshalAs(UnmanagedType.I4), FieldOffset(1)]
            internal int m_edition;
            [MarshalAs(UnmanagedType.I4), FieldOffset(5)]
            internal int m_index_info_length;
            [MarshalAs(UnmanagedType.I4), FieldOffset(9)]
            internal int m_body_info_length;
            [MarshalAs(UnmanagedType.U1), FieldOffset(13)]
            internal byte m_last_mark;
            [MarshalAs(UnmanagedType.I4), FieldOffset(14)]
            internal int m_file_count;
        }

        [StructLayout(LayoutKind.Sequential)]
        private class WXAPKG_FILE
        {
            internal int m_name_length;
            internal string m_name;
            internal int m_offset;
            internal int m_size;
        }

        #endregion

        public string FormatCapability(UInt64 nCapability, int nDigits = 2)
        {
            string szCapability = "";
            if (nCapability < 1024)
            {
                szCapability = nCapability + " B";
            }
            else if (nCapability < 1024 * 1024)
            {
                szCapability = (nCapability / 1024.0).ToString("F" + nDigits) + " KB";
            }
            else if (nCapability < 1024 * 1024 * 1024)
            {
                szCapability = (nCapability / 1024.0 / 1024.0).ToString("F" + nDigits) + " MB";
            }
            else
            {
                szCapability = (nCapability / 1024.0 / 1024.0 / 1024.0).ToString("F" + nDigits) + " GB";
            }

            return szCapability;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWXAPKG_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != ofd.ShowDialog())
            {
                return;
            }

            txtContent.Text = "";
            txtWXAPKG.Text = ofd.FileName;
            lvwFileList.Items.Clear();
            tvwFileList.Nodes.Clear();

            // WXAPKG 格式：https://toutiao.io/posts/33fum8/preview

            FileStream fs = null;
            try
            {
                fs = new FileStream(txtWXAPKG.Text, FileMode.Open, FileAccess.Read);

                // 获取头部信息
                WXAPKG_HEADER header = new WXAPKG_HEADER();

                // 第一个标识，固定为 0xBE
                header.m_first_mark = (byte)fs.ReadByte();
                if (0xBE != header.m_first_mark)
                {
                    throw new Exception("文件第一个标识有误，非 WXAPKG 格式文件！");
                }

                // 版本号，0 -> 微信分发到客户端 1 -> 开发者上传到微信后台
                byte[] b_int = new byte[4];
                fs.Read(b_int, 0, b_int.Length);
                header.m_edition = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                // 索引段的长度
                fs.Read(b_int, 0, b_int.Length);
                header.m_index_info_length = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                // 数据段的长度
                fs.Read(b_int, 0, b_int.Length);
                header.m_body_info_length = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                // 第二个标识，固定为 0xED
                header.m_last_mark = (byte)fs.ReadByte();
                if (0xED != header.m_last_mark)
                {
                    throw new Exception("文件标识有误，非 WXAPKG 格式文件！");
                }

                // 文件数量
                fs.Read(b_int, 0, b_int.Length);
                header.m_file_count = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                tvwFileList.BeginUpdate();
                TreeNode tn_root = tvwFileList.Nodes.Add("/");

                lvwFileList.BeginUpdate();

                // 获取每个文件的信息
                for (int i = 0; i < header.m_file_count; i++)
                {
                    WXAPKG_FILE file = new WXAPKG_FILE();

                    // 文件长度
                    fs.Read(b_int, 0, b_int.Length);
                    file.m_name_length = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                    if (file.m_name_length > 255)
                    {
                        throw new Exception("错误的文件长度！");
                    }

                    // 文件名
                    byte[] b_name = new byte[file.m_name_length];
                    fs.Read(b_name, 0, b_name.Length);
                    file.m_name = Encoding.UTF8.GetString(b_name);

                    // 偏移
                    fs.Read(b_int, 0, b_int.Length);
                    file.m_offset = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                    // 大小
                    fs.Read(b_int, 0, b_int.Length);
                    file.m_size = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(b_int, 0));

                    // 添加到列表框
                    ListViewItem lvi = new ListViewItem(file.m_name);
                    lvi.SubItems.Add(FormatCapability((UInt64)file.m_size));
                    lvi.SubItems.Add(file.m_offset.ToString());
                    lvi.Tag = file;

                    lvwFileList.Items.Add(lvi);

                    // 添加到树形框
                    AddTreeNode(tn_root, file.m_name, file);
                }

                lvwFileList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwFileList.EndUpdate();

                tvwFileList.ExpandAll();
                tvwFileList.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        private void AddTreeNode(TreeNode tn_parent, string file_name, WXAPKG_FILE file)
        {
            TreeNode tn = null;
            string[] arr_path = file_name.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (tn_parent.Nodes.ContainsKey(arr_path[0]))
            {
                tn = tn_parent.Nodes[arr_path[0]];
            }
            else
            {
                tn = new TreeNode(arr_path[0]);
                tn.Name = arr_path[0];
                tn_parent.Nodes.Add(tn);
            }

            file_name = string.Join("/", arr_path);
            if (file_name.IndexOf('/', 1) < 0)
            {
                tn.Tag = file;
                tn.ToolTipText =
                    "大小：" + FormatCapability((UInt64)file.m_size) +
                    " 偏移：" + file.m_offset;
                return;
            }

            file_name = file_name.Substring(file_name.IndexOf('/', 1));
            AddTreeNode(tn, file_name, file);
        }

        private void ShowFileContent(WXAPKG_FILE file)
        {
            if ("" == txtWXAPKG.Text ||
                null == file)
            {
                return;
            }

            FileStream fs = null;
            try
            {
                fs = new FileStream(txtWXAPKG.Text, FileMode.Open, FileAccess.Read);

                byte[] b_content = new byte[file.m_size];
                fs.Seek((long)file.m_offset, SeekOrigin.Begin);
                fs.Read(b_content, 0, file.m_size);
                fs.Close();

                string content = Encoding.UTF8.GetString(b_content);
                if (btnBeautifyJS.Checked &&
                    (file.m_name.EndsWith(".js") ||
                     file.m_name.EndsWith(".json")))
                {
                    JSBeautifyOptions jsbo = new JSBeautifyOptions();
                    JSBeautify jsb = new JSBeautify(content, jsbo);
                    content = jsb.GetResult();
                }

                txtContent.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        private void lvwFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 != lvwFileList.SelectedItems.Count)
            {
                return;
            }

            WXAPKG_FILE file = lvwFileList.SelectedItems[0].Tag as WXAPKG_FILE;
            if (null == file)
            {
                return;
            }

            ShowFileContent(file);
        }

        private void tvwFileList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (null == e.Node ||
                e.Node.Nodes.Count > 0)
            {
                return;
            }

            WXAPKG_FILE file = e.Node.Tag as WXAPKG_FILE;
            if (null == file)
            {
                return;
            }

            ShowFileContent(file);
        }

        private void btnViewSwitch_Click(object sender, EventArgs e)
        {
            btnListView.Checked = false;
            btnTreeView.Checked = false;
            ((ToolStripButton)sender).Checked = true;

            if (sender == btnListView)
            {
                lvwFileList.BringToFront();
            }
            else
            {
                tvwFileList.BringToFront();
            }
        }

        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            txtContent.WordWrap = btnWordWrap.Checked;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtContent.Text);
            Application.DoEvents();

            MessageBox.Show("已复制到剪贴板！");
        }

        private void btnLink1_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "http://www.bejson.com/jshtml_format/");
        }

        private void btnLink2_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "https://beautifier.io");
        }

        private void btnBeautifyJS_Click(object sender, EventArgs e)
        {
            if (btnBeautifyJS.Checked)
            {
                if (DialogResult.Yes != MessageBox.Show(
                    "此操作可能导致界面卡死，是否确认使用？", "使用确认",
                    MessageBoxButtons.YesNo))
                {
                    btnBeautifyJS.Checked = false;
                    return;
                }
            }
        }
    }
}
