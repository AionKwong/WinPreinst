namespace WinPreinst
{
    partial class preinst
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preinst));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.preinstTool = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourTool = new System.Windows.Forms.ToolStripMenuItem();
            this.kettleTool = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlAppendTool = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.winTools = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preinstTool,
            this.sqlAppendTool,
            this.XMLFormatToolStripMenuItem,
            this.DecToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(982, 28);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStripTop";
            // 
            // preinstTool
            // 
            this.preinstTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourTool,
            this.kettleTool});
            this.preinstTool.Name = "preinstTool";
            this.preinstTool.Size = new System.Drawing.Size(98, 24);
            this.preinstTool.Text = "加解密工具";
            // 
            // dataSourTool
            // 
            this.dataSourTool.Name = "dataSourTool";
            this.dataSourTool.Size = new System.Drawing.Size(250, 26);
            this.dataSourTool.Text = "第三方数据源解密(DES)";
            this.dataSourTool.Click += new System.EventHandler(this.DataSourTool_Click);
            // 
            // kettleTool
            // 
            this.kettleTool.Name = "kettleTool";
            this.kettleTool.Size = new System.Drawing.Size(250, 26);
            this.kettleTool.Text = "KETTLE连接解密";
            this.kettleTool.Click += new System.EventHandler(this.KettleTool_Click);
            // 
            // sqlAppendTool
            // 
            this.sqlAppendTool.Name = "sqlAppendTool";
            this.sqlAppendTool.Size = new System.Drawing.Size(112, 24);
            this.sqlAppendTool.Text = "SQL参数拼接";
            this.sqlAppendTool.Click += new System.EventHandler(this.SqlAppendTool_Click);
            // 
            // XMLFormatToolStripMenuItem
            // 
            this.XMLFormatToolStripMenuItem.Name = "XMLFormatToolStripMenuItem";
            this.XMLFormatToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.XMLFormatToolStripMenuItem.Text = "XML格式化";
            this.XMLFormatToolStripMenuItem.Click += new System.EventHandler(this.XMLFormatToolStripMenuItem_Click);
            // 
            // DecToolStripMenuItem
            // 
            this.DecToolStripMenuItem.Name = "DecToolStripMenuItem";
            this.DecToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.DecToolStripMenuItem.Text = "报文解压";
            this.DecToolStripMenuItem.Click += new System.EventHandler(this.DecToolStripMenuItem_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(958, 691);
            this.flowLayoutPanelMain.TabIndex = 1;
            // 
            // winTools
            // 
            this.winTools.Icon = ((System.Drawing.Icon)(resources.GetObject("winTools.Icon")));
            this.winTools.Text = "维护工具";
            this.winTools.Visible = true;
            // 
            // preinst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.menuStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "preinst";
            this.Text = "维护工具";
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem preinstTool;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.ToolStripMenuItem dataSourTool;
        private System.Windows.Forms.ToolStripMenuItem sqlAppendTool;
        private System.Windows.Forms.NotifyIcon winTools;
        private System.Windows.Forms.ToolStripMenuItem XMLFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kettleTool;
        private System.Windows.Forms.ToolStripMenuItem DecToolStripMenuItem;
    }
}

