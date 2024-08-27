
namespace WinPreinst.todo.fromcs
{
    partial class DecXMLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecXMLForm));
            this.labelInputText = new System.Windows.Forms.Label();
            this.richTextBase64 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxXML = new System.Windows.Forms.RichTextBox();
            this.labelOutputText = new System.Windows.Forms.Label();
            this.decButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.decMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Location = new System.Drawing.Point(13, 16);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new System.Drawing.Size(130, 15);
            this.labelInputText.TabIndex = 0;
            this.labelInputText.Text = "输入base64字符串";
            // 
            // richTextBase64
            // 
            this.richTextBase64.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBase64.Location = new System.Drawing.Point(12, 41);
            this.richTextBase64.Name = "richTextBase64";
            this.richTextBase64.Size = new System.Drawing.Size(355, 497);
            this.richTextBase64.TabIndex = 1;
            this.richTextBase64.Text = "";
            this.richTextBase64.MouseEnter += new System.EventHandler(this.RichTextBase64_MouseEnter);
            // 
            // richTextBoxXML
            // 
            this.richTextBoxXML.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxXML.Location = new System.Drawing.Point(398, 41);
            this.richTextBoxXML.Name = "richTextBoxXML";
            this.richTextBoxXML.Size = new System.Drawing.Size(406, 497);
            this.richTextBoxXML.TabIndex = 2;
            this.richTextBoxXML.Text = "";
            // 
            // labelOutputText
            // 
            this.labelOutputText.AutoSize = true;
            this.labelOutputText.Location = new System.Drawing.Point(395, 16);
            this.labelOutputText.Name = "labelOutputText";
            this.labelOutputText.Size = new System.Drawing.Size(91, 15);
            this.labelOutputText.TabIndex = 3;
            this.labelOutputText.Text = "输出明文XML";
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(447, 551);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(95, 37);
            this.decButton.TabIndex = 4;
            this.decButton.Text = "解压";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(718, 551);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(86, 37);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "复制XML";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(584, 551);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(93, 37);
            this.cleanButton.TabIndex = 6;
            this.cleanButton.Text = "清空";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // decMessageLabel
            // 
            this.decMessageLabel.AutoSize = true;
            this.decMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.decMessageLabel.Location = new System.Drawing.Point(12, 562);
            this.decMessageLabel.Name = "decMessageLabel";
            this.decMessageLabel.Size = new System.Drawing.Size(0, 15);
            this.decMessageLabel.TabIndex = 7;
            // 
            // DecXMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 603);
            this.Controls.Add(this.decMessageLabel);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.labelOutputText);
            this.Controls.Add(this.richTextBoxXML);
            this.Controls.Add(this.richTextBase64);
            this.Controls.Add(this.labelInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecXMLForm";
            this.Text = "报文解压";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputText;
        private System.Windows.Forms.RichTextBox richTextBase64;
        private System.Windows.Forms.RichTextBox richTextBoxXML;
        private System.Windows.Forms.Label labelOutputText;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label decMessageLabel;
    }
}