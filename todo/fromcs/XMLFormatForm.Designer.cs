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
            this.DeleteXMLButton = new System.Windows.Forms.Button();
            this.OpenXMLButton = new System.Windows.Forms.Button();
            this.FormatButton = new System.Windows.Forms.Button();
            this.DirectorXMLlabel = new System.Windows.Forms.Label();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.labelOpenPath = new System.Windows.Forms.Label();
            this.XmlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLMessageLabel
            // 
            this.XMLMessageLabel.AutoSize = true;
            this.XMLMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.XMLMessageLabel.Location = new System.Drawing.Point(18, 157);
            this.XMLMessageLabel.Name = "XMLMessageLabel";
            this.XMLMessageLabel.Size = new System.Drawing.Size(67, 15);
            this.XMLMessageLabel.TabIndex = 5;
            this.XMLMessageLabel.Text = "提示信息";
            // 
            // XmlGroupBox
            // 
            this.XmlGroupBox.Controls.Add(this.XMLMessageLabel);
            this.XmlGroupBox.Controls.Add(this.DeleteXMLButton);
            this.XmlGroupBox.Controls.Add(this.OpenXMLButton);
            this.XmlGroupBox.Controls.Add(this.FormatButton);
            this.XmlGroupBox.Controls.Add(this.DirectorXMLlabel);
            this.XmlGroupBox.Controls.Add(this.AddFileButton);
            this.XmlGroupBox.Location = new System.Drawing.Point(28, 28);
            this.XmlGroupBox.Name = "XmlGroupBox";
            this.XmlGroupBox.Size = new System.Drawing.Size(615, 190);
            this.XmlGroupBox.TabIndex = 4;
            this.XmlGroupBox.TabStop = false;
            this.XmlGroupBox.Text = "XML";
            // 
            // DeleteXMLButton
            // 
            this.DeleteXMLButton.Location = new System.Drawing.Point(305, 95);
            this.DeleteXMLButton.Name = "DeleteXMLButton";
            this.DeleteXMLButton.Size = new System.Drawing.Size(114, 30);
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
            this.OpenXMLButton.Location = new System.Drawing.Point(175, 95);
            this.OpenXMLButton.Name = "OpenXMLButton";
            this.OpenXMLButton.Size = new System.Drawing.Size(113, 30);
            this.OpenXMLButton.TabIndex = 5;
            this.OpenXMLButton.Text = "直接打开文件";
            this.OpenXMLButton.UseVisualStyleBackColor = true;
            this.OpenXMLButton.Click += new System.EventHandler(this.OpenXMLButton_Click);
            // 
            // FormatButton
            // 
            this.FormatButton.Location = new System.Drawing.Point(19, 95);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(139, 30);
            this.FormatButton.TabIndex = 2;
            this.FormatButton.Text = "格式化XML";
            this.FormatButton.UseVisualStyleBackColor = true;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // DirectorXMLlabel
            // 
            this.DirectorXMLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectorXMLlabel.AutoSize = true;
            this.DirectorXMLlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectorXMLlabel.Location = new System.Drawing.Point(177, 45);
            this.DirectorXMLlabel.Name = "DirectorXMLlabel";
            this.DirectorXMLlabel.Size = new System.Drawing.Size(2, 17);
            this.DirectorXMLlabel.TabIndex = 1;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(21, 37);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(139, 30);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "选择XML内容文件";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // labelOpenPath
            // 
            this.labelOpenPath.AutoSize = true;
            this.labelOpenPath.Location = new System.Drawing.Point(46, 221);
            this.labelOpenPath.Name = "labelOpenPath";
            this.labelOpenPath.Size = new System.Drawing.Size(0, 15);
            this.labelOpenPath.TabIndex = 5;
            // 
            // XMLFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 239);
            this.Controls.Add(this.labelOpenPath);
            this.Controls.Add(this.XmlGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLFormatForm";
            this.Text = "格式化XML";
            this.XmlGroupBox.ResumeLayout(false);
            this.XmlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XMLMessageLabel;
        private System.Windows.Forms.GroupBox XmlGroupBox;
        private System.Windows.Forms.Button DeleteXMLButton;
        private System.Windows.Forms.Button OpenXMLButton;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.Label DirectorXMLlabel;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Label labelOpenPath;
    }
}