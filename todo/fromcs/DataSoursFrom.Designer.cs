namespace WinPreinst
{
    partial class DataSoursFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSoursFrom));
            this.richTextProcl = new System.Windows.Forms.RichTextBox();
            this.richTextCiph = new System.Windows.Forms.RichTextBox();
            this.bottonProcl = new System.Windows.Forms.Button();
            this.labelProcl = new System.Windows.Forms.Label();
            this.labelCiph = new System.Windows.Forms.Label();
            this.buttonCiph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextProcl
            // 
            this.richTextProcl.Location = new System.Drawing.Point(30, 53);
            this.richTextProcl.Name = "richTextProcl";
            this.richTextProcl.Size = new System.Drawing.Size(180, 266);
            this.richTextProcl.TabIndex = 0;
            this.richTextProcl.Text = "";
            // 
            // richTextCiph
            // 
            this.richTextCiph.Location = new System.Drawing.Point(357, 53);
            this.richTextCiph.Name = "richTextCiph";
            this.richTextCiph.Size = new System.Drawing.Size(198, 266);
            this.richTextCiph.TabIndex = 1;
            this.richTextCiph.Text = "";
            // 
            // bottonProcl
            // 
            this.bottonProcl.Location = new System.Drawing.Point(239, 227);
            this.bottonProcl.Name = "bottonProcl";
            this.bottonProcl.Size = new System.Drawing.Size(85, 29);
            this.bottonProcl.TabIndex = 2;
            this.bottonProcl.Text = "<<解密";
            this.bottonProcl.UseVisualStyleBackColor = true;
            this.bottonProcl.Click += new System.EventHandler(this.BottonProcl_Click);
            // 
            // labelProcl
            // 
            this.labelProcl.AutoSize = true;
            this.labelProcl.Location = new System.Drawing.Point(62, 26);
            this.labelProcl.Name = "labelProcl";
            this.labelProcl.Size = new System.Drawing.Size(97, 15);
            this.labelProcl.TabIndex = 3;
            this.labelProcl.Text = "输入明文密码";
            // 
            // labelCiph
            // 
            this.labelCiph.AutoSize = true;
            this.labelCiph.Location = new System.Drawing.Point(410, 26);
            this.labelCiph.Name = "labelCiph";
            this.labelCiph.Size = new System.Drawing.Size(97, 15);
            this.labelCiph.TabIndex = 4;
            this.labelCiph.Text = "输入加密密码";
            // 
            // buttonCiph
            // 
            this.buttonCiph.Location = new System.Drawing.Point(237, 161);
            this.buttonCiph.Name = "buttonCiph";
            this.buttonCiph.Size = new System.Drawing.Size(87, 30);
            this.buttonCiph.TabIndex = 5;
            this.buttonCiph.Text = "加密>>";
            this.buttonCiph.UseVisualStyleBackColor = true;
            this.buttonCiph.Click += new System.EventHandler(this.ButtonCiph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "设置KEY";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(233, 108);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(95, 25);
            this.textKey.TabIndex = 7;
            // 
            // DataSoursFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCiph);
            this.Controls.Add(this.labelCiph);
            this.Controls.Add(this.labelProcl);
            this.Controls.Add(this.bottonProcl);
            this.Controls.Add(this.richTextCiph);
            this.Controls.Add(this.richTextProcl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataSoursFrom";
            this.Text = "第三方数据源解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextProcl;
        private System.Windows.Forms.RichTextBox richTextCiph;
        private System.Windows.Forms.Button bottonProcl;
        private System.Windows.Forms.Label labelProcl;
        private System.Windows.Forms.Label labelCiph;
        private System.Windows.Forms.Button buttonCiph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKey;
    }
}