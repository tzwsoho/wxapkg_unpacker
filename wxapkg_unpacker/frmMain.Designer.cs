namespace wxapkg_unpacker
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwFileList = new System.Windows.Forms.TreeView();
            this.lvwFileList = new System.Windows.Forms.ListView();
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsList = new System.Windows.Forms.ToolStrip();
            this.btnTreeView = new System.Windows.Forms.ToolStripButton();
            this.btnListView = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tsContent = new System.Windows.Forms.ToolStrip();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnBeautifyJS = new System.Windows.Forms.ToolStripButton();
            this.btnWordWrap = new System.Windows.Forms.ToolStripButton();
            this.btnLink2 = new System.Windows.Forms.ToolStripButton();
            this.btnLink1 = new System.Windows.Forms.ToolStripButton();
            this.gbWXAPKG = new System.Windows.Forms.GroupBox();
            this.btnWXAPKG = new System.Windows.Forms.Button();
            this.txtWXAPKG = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.picPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsList.SuspendLayout();
            this.tsContent.SuspendLayout();
            this.gbWXAPKG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwFileList);
            this.splitContainer1.Panel1.Controls.Add(this.lvwFileList);
            this.splitContainer1.Panel1.Controls.Add(this.tsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picPreview);
            this.splitContainer1.Panel2.Controls.Add(this.txtContent);
            this.splitContainer1.Panel2.Controls.Add(this.tsContent);
            this.splitContainer1.Size = new System.Drawing.Size(981, 450);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvwFileList
            // 
            this.tvwFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFileList.Location = new System.Drawing.Point(0, 25);
            this.tvwFileList.Name = "tvwFileList";
            this.tvwFileList.PathSeparator = "/";
            this.tvwFileList.ShowNodeToolTips = true;
            this.tvwFileList.Size = new System.Drawing.Size(288, 425);
            this.tvwFileList.TabIndex = 1;
            this.tvwFileList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwFileList_NodeMouseClick);
            // 
            // lvwFileList
            // 
            this.lvwFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilename,
            this.colSize,
            this.colOffset});
            this.lvwFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFileList.FullRowSelect = true;
            this.lvwFileList.GridLines = true;
            this.lvwFileList.HideSelection = false;
            this.lvwFileList.Location = new System.Drawing.Point(0, 25);
            this.lvwFileList.MultiSelect = false;
            this.lvwFileList.Name = "lvwFileList";
            this.lvwFileList.Size = new System.Drawing.Size(288, 425);
            this.lvwFileList.TabIndex = 0;
            this.lvwFileList.UseCompatibleStateImageBehavior = false;
            this.lvwFileList.View = System.Windows.Forms.View.Details;
            this.lvwFileList.SelectedIndexChanged += new System.EventHandler(this.lvwFileList_SelectedIndexChanged);
            // 
            // colFilename
            // 
            this.colFilename.Text = "文件名";
            this.colFilename.Width = 100;
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            // 
            // colOffset
            // 
            this.colOffset.Text = "偏移";
            // 
            // tsList
            // 
            this.tsList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTreeView,
            this.btnListView,
            this.btnSaveAs});
            this.tsList.Location = new System.Drawing.Point(0, 0);
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(288, 25);
            this.tsList.TabIndex = 2;
            this.tsList.Text = "toolStrip1";
            // 
            // btnTreeView
            // 
            this.btnTreeView.Checked = true;
            this.btnTreeView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnTreeView.Image = ((System.Drawing.Image)(resources.GetObject("btnTreeView.Image")));
            this.btnTreeView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(64, 22);
            this.btnTreeView.Text = "树形框";
            this.btnTreeView.Click += new System.EventHandler(this.btnViewSwitch_Click);
            // 
            // btnListView
            // 
            this.btnListView.Image = ((System.Drawing.Image)(resources.GetObject("btnListView.Image")));
            this.btnListView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(64, 22);
            this.btnListView.Text = "列表框";
            this.btnListView.Click += new System.EventHandler(this.btnViewSwitch_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(73, 22);
            this.btnSaveAs.Text = "另存为...";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 25);
            this.txtContent.MaxLength = 0;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(689, 425);
            this.txtContent.TabIndex = 0;
            // 
            // tsContent
            // 
            this.tsContent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnBeautifyJS,
            this.btnWordWrap,
            this.btnLink2,
            this.btnLink1});
            this.tsContent.Location = new System.Drawing.Point(0, 0);
            this.tsContent.Name = "tsContent";
            this.tsContent.Size = new System.Drawing.Size(689, 25);
            this.tsContent.TabIndex = 1;
            this.tsContent.Text = "toolStrip2";
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(76, 22);
            this.btnCopy.Text = "复制代码";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnBeautifyJS
            // 
            this.btnBeautifyJS.CheckOnClick = true;
            this.btnBeautifyJS.Image = ((System.Drawing.Image)(resources.GetObject("btnBeautifyJS.Image")));
            this.btnBeautifyJS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBeautifyJS.Name = "btnBeautifyJS";
            this.btnBeautifyJS.Size = new System.Drawing.Size(76, 22);
            this.btnBeautifyJS.Text = "美化代码";
            this.btnBeautifyJS.ToolTipText = "此操作可能耗时非常久，慎用！！！";
            this.btnBeautifyJS.Click += new System.EventHandler(this.btnBeautifyJS_Click);
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.Checked = true;
            this.btnWordWrap.CheckOnClick = true;
            this.btnWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("btnWordWrap.Image")));
            this.btnWordWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWordWrap.Name = "btnWordWrap";
            this.btnWordWrap.Size = new System.Drawing.Size(76, 22);
            this.btnWordWrap.Text = "自动换行";
            this.btnWordWrap.Click += new System.EventHandler(this.btnWordWrap_Click);
            // 
            // btnLink2
            // 
            this.btnLink2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLink2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLink2.Image = ((System.Drawing.Image)(resources.GetObject("btnLink2.Image")));
            this.btnLink2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLink2.Name = "btnLink2";
            this.btnLink2.Size = new System.Drawing.Size(23, 22);
            this.btnLink2.Text = "https://beautifier.io";
            this.btnLink2.ToolTipText = "跳转到 https://beautifier.io";
            this.btnLink2.Click += new System.EventHandler(this.btnLink2_Click);
            // 
            // btnLink1
            // 
            this.btnLink1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLink1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLink1.Image = ((System.Drawing.Image)(resources.GetObject("btnLink1.Image")));
            this.btnLink1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLink1.Name = "btnLink1";
            this.btnLink1.Size = new System.Drawing.Size(23, 22);
            this.btnLink1.Text = "http://www.bejson.com/jshtml_format/";
            this.btnLink1.ToolTipText = "跳转到 http://www.bejson.com/jshtml_format/";
            this.btnLink1.Click += new System.EventHandler(this.btnLink1_Click);
            // 
            // gbWXAPKG
            // 
            this.gbWXAPKG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWXAPKG.Controls.Add(this.btnWXAPKG);
            this.gbWXAPKG.Controls.Add(this.txtWXAPKG);
            this.gbWXAPKG.Location = new System.Drawing.Point(12, 12);
            this.gbWXAPKG.Name = "gbWXAPKG";
            this.gbWXAPKG.Size = new System.Drawing.Size(981, 54);
            this.gbWXAPKG.TabIndex = 1;
            this.gbWXAPKG.TabStop = false;
            this.gbWXAPKG.Text = "选择一个包";
            // 
            // btnWXAPKG
            // 
            this.btnWXAPKG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWXAPKG.Location = new System.Drawing.Point(941, 19);
            this.btnWXAPKG.Name = "btnWXAPKG";
            this.btnWXAPKG.Size = new System.Drawing.Size(34, 23);
            this.btnWXAPKG.TabIndex = 1;
            this.btnWXAPKG.Text = "...";
            this.btnWXAPKG.UseVisualStyleBackColor = true;
            this.btnWXAPKG.Click += new System.EventHandler(this.btnWXAPKG_Click);
            // 
            // txtWXAPKG
            // 
            this.txtWXAPKG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWXAPKG.Location = new System.Drawing.Point(6, 20);
            this.txtWXAPKG.Name = "txtWXAPKG";
            this.txtWXAPKG.ReadOnly = true;
            this.txtWXAPKG.Size = new System.Drawing.Size(929, 21);
            this.txtWXAPKG.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "wxapkg";
            this.ofd.Filter = "WXAPKG 文件(*.wxapkg)|*.wxapkg|所有文件(*.*)|*.*";
            // 
            // picPreview
            // 
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(0, 25);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(689, 425);
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 534);
            this.Controls.Add(this.gbWXAPKG);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wxapkg解包 -- TZWSOHO";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsList.ResumeLayout(false);
            this.tsList.PerformLayout();
            this.tsContent.ResumeLayout(false);
            this.tsContent.PerformLayout();
            this.gbWXAPKG.ResumeLayout(false);
            this.gbWXAPKG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwFileList;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colOffset;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox gbWXAPKG;
        private System.Windows.Forms.Button btnWXAPKG;
        private System.Windows.Forms.TextBox txtWXAPKG;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TreeView tvwFileList;
        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton btnTreeView;
        private System.Windows.Forms.ToolStripButton btnListView;
        private System.Windows.Forms.ToolStrip tsContent;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnLink2;
        private System.Windows.Forms.ToolStripButton btnWordWrap;
        private System.Windows.Forms.ToolStripButton btnBeautifyJS;
        private System.Windows.Forms.ToolStripButton btnLink1;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.PictureBox picPreview;
    }
}

