namespace WinPreinst
{
    partial class KettleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KettleForm));
            this.buttonCiphKettle = new System.Windows.Forms.Button();
            this.labelCiphKettle = new System.Windows.Forms.Label();
            this.labelProclKettle = new System.Windows.Forms.Label();
            this.bottonProclKettle = new System.Windows.Forms.Button();
            this.richTextCiphKettle = new System.Windows.Forms.RichTextBox();
            this.richTextProclKettle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCiphKettle
            // 
            this.buttonCiphKettle.Location = new System.Drawing.Point(236, 134);
            this.buttonCiphKettle.Name = "buttonCiphKettle";
            this.buttonCiphKettle.Size = new System.Drawing.Size(87, 30);
            this.buttonCiphKettle.TabIndex = 11;
            this.buttonCiphKettle.Text = "加密>>";
            this.buttonCiphKettle.UseVisualStyleBackColor = true;
            this.buttonCiphKettle.Click += new System.EventHandler(this.ButtonCiphKettle_Click);
            // 
            // labelCiphKettle
            // 
            this.labelCiphKettle.AutoSize = true;
            this.labelCiphKettle.Location = new System.Drawing.Point(409, 30);
            this.labelCiphKettle.Name = "labelCiphKettle";
            this.labelCiphKettle.Size = new System.Drawing.Size(97, 15);
            this.labelCiphKettle.TabIndex = 10;
            this.labelCiphKettle.Text = "输入加密密码";
            // 
            // labelProclKettle
            // 
            this.labelProclKettle.AutoSize = true;
            this.labelProclKettle.Location = new System.Drawing.Point(61, 30);
            this.labelProclKettle.Name = "labelProclKettle";
            this.labelProclKettle.Size = new System.Drawing.Size(97, 15);
            this.labelProclKettle.TabIndex = 9;
            this.labelProclKettle.Text = "输入明文密码";
            // 
            // bottonProclKettle
            // 
            this.bottonProclKettle.Location = new System.Drawing.Point(238, 200);
            this.bottonProclKettle.Name = "bottonProclKettle";
            this.bottonProclKettle.Size = new System.Drawing.Size(85, 29);
            this.bottonProclKettle.TabIndex = 8;
            this.bottonProclKettle.Text = "<<解密";
            this.bottonProclKettle.UseVisualStyleBackColor = true;
            this.bottonProclKettle.Click += new System.EventHandler(this.BottonProclKettle_Click);
            // 
            // richTextCiphKettle
            // 
            this.richTextCiphKettle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextCiphKettle.Location = new System.Drawing.Point(356, 57);
            this.richTextCiphKettle.Name = "richTextCiphKettle";
            this.richTextCiphKettle.Size = new System.Drawing.Size(198, 266);
            this.richTextCiphKettle.TabIndex = 7;
            this.richTextCiphKettle.Text = "";
            // 
            // richTextProclKettle
            // 
            this.richTextProclKettle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextProclKettle.Location = new System.Drawing.Point(29, 57);
            this.richTextProclKettle.Name = "richTextProclKettle";
            this.richTextProclKettle.Size = new System.Drawing.Size(180, 266);
            this.richTextProclKettle.TabIndex = 6;
            this.richTextProclKettle.Text = "";
            this.richTextProclKettle.MouseEnter += new System.EventHandler(this.RichTextProclKettle_MouseEnter);
            // 
            // KettleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.buttonCiphKettle);
            this.Controls.Add(this.labelCiphKettle);
            this.Controls.Add(this.labelProclKettle);
            this.Controls.Add(this.bottonProclKettle);
            this.Controls.Add(this.richTextCiphKettle);
            this.Controls.Add(this.richTextProclKettle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "KettleForm";
            this.Text = "KETTLE解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCiphKettle;
        private System.Windows.Forms.Label labelCiphKettle;
        private System.Windows.Forms.Label labelProclKettle;
        private System.Windows.Forms.Button bottonProclKettle;
        private System.Windows.Forms.RichTextBox richTextCiphKettle;
        private System.Windows.Forms.RichTextBox richTextProclKettle;
    }
}