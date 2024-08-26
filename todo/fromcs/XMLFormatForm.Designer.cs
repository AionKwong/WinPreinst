namespace WinPreinst.todo.fromcs
{
    partial class XMLFormatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLFormatForm));
            this.XMLMessageLabel = new System.Windows.Forms.Label();
            this.XmlGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.DeleteXMLButton = new System.Windows.Forms.Button();
            this.OpenXMLButton = new System.Windows.Forms.Button();
            this.FormatButton = new System.Windows.Forms.Button();
            this.labelOpenPath = new System.Windows.Forms.Label();
            this.XmlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLMessageLabel
            // 
            this.XMLMessageLabel.AutoSize = true;
            this.XMLMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.XMLMessageLabel.Location = new System.Drawing.Point(25, 569);
            this.XMLMessageLabel.Name = "XMLMessageLabel";
            this.XMLMessageLabel.Size = new System.Drawing.Size(67, 15);
            this.XMLMessageLabel.TabIndex = 5;
            this.XMLMessageLabel.Text = "提示信息";
            // 
            // XmlGroupBox
            // 
            this.XmlGroupBox.Controls.Add(this.richTextBoxOut);
            this.XmlGroupBox.Controls.Add(this.saveFileButton);
            this.XmlGroupBox.Controls.Add(this.richTextBoxIn);
            this.XmlGroupBox.Controls.Add(this.DeleteXMLButton);
            this.XmlGroupBox.Controls.Add(this.OpenXMLButton);
            this.XmlGroupBox.Controls.Add(this.FormatButton);
            this.XmlGroupBox.Location = new System.Drawing.Point(28, 28);
            this.XmlGroupBox.Name = "XmlGroupBox";
            this.XmlGroupBox.Size = new System.Drawing.Size(853, 525);
            this.XmlGroupBox.TabIndex = 4;
            this.XmlGroupBox.TabStop = false;
            this.XmlGroupBox.Text = "XML";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(484, 24);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(353, 485);
            this.richTextBoxOut.TabIndex = 9;
            this.richTextBoxOut.Text = "";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileButton.Location = new System.Drawing.Point(369, 160);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(96, 30);
            this.saveFileButton.TabIndex = 8;
            this.saveFileButton.Text = "保存文件";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Location = new System.Drawing.Point(21, 24);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(324, 485);
            this.richTextBoxIn.TabIndex = 7;
            this.richTextBoxIn.Text = "";
            this.richTextBoxIn.MouseEnter += new System.EventHandler(this.RichTextBoxIn_MouseEnter);
            // 
            // DeleteXMLButton
            // 
            this.DeleteXMLButton.Location = new System.Drawing.Point(369, 358);
            this.DeleteXMLButton.Name = "DeleteXMLButton";
            this.DeleteXMLButton.Size = new System.Drawing.Size(96, 30);
            this.DeleteXMLButton.TabIndex = 6;
            this.DeleteXMLButton.Text = "删除文件";
            this.DeleteXMLButton.UseVisualStyleBackColor = true;
            this.DeleteXMLButton.Click += new System.EventHandler(this.DeleteXMLButton_Click);
            // 
            // OpenXMLButton
            // 
            this.OpenXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenXMLButton.Location = new System.Drawing.Point(369, 249);
            this.OpenXMLButton.Name = "OpenXMLButton";
            this.OpenXMLButton.Size = new System.Drawing.Size(96, 30);
            this.OpenXMLButton.TabIndex = 5;
            this.OpenXMLButton.Text = "打开文件";
            this.OpenXMLButton.UseVisualStyleBackColor = true;
            this.OpenXMLButton.Click += new System.EventHandler(this.OpenXMLButton_Click);
            // 
            // FormatButton
            // 
            this.FormatButton.Location = new System.Drawing.Point(369, 63);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(96, 30);
            this.FormatButton.TabIndex = 2;
            this.FormatButton.Text = "格式化XML";
            this.FormatButton.UseVisualStyleBackColor = true;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // labelOpenPath
            // 
            this.labelOpenPath.AutoSize = true;
            this.labelOpenPath.Location = new System.Drawing.Point(29, 594);
            this.labelOpenPath.Name = "labelOpenPath";
            this.labelOpenPath.Size = new System.Drawing.Size(0, 15);
            this.labelOpenPath.TabIndex = 5;
            // 
            // XMLFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 617);
            this.Controls.Add(this.XMLMessageLabel);
            this.Controls.Add(this.labelOpenPath);
            this.Controls.Add(this.XmlGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLFormatForm";
            this.Text = "格式化XML";
            this.XmlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XMLMessageLabel;
        private System.Windows.Forms.GroupBox XmlGroupBox;
        private System.Windows.Forms.Button DeleteXMLButton;
        private System.Windows.Forms.Button OpenXMLButton;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.Label labelOpenPath;
        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
    }
}