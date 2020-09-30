namespace WinPreinst
{
    partial class SqlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlForm));
            this.MessageLabel = new System.Windows.Forms.Label();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Paramslabel = new System.Windows.Forms.Label();
            this.ParamsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Directorlabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.LogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(40, 237);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(67, 15);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "提示信息";
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.buttonDelete);
            this.LogGroupBox.Controls.Add(this.OpenButton);
            this.LogGroupBox.Controls.Add(this.Paramslabel);
            this.LogGroupBox.Controls.Add(this.ParamsButton);
            this.LogGroupBox.Controls.Add(this.SaveButton);
            this.LogGroupBox.Controls.Add(this.Directorlabel);
            this.LogGroupBox.Controls.Add(this.AddButton);
            this.LogGroupBox.Location = new System.Drawing.Point(37, 22);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(616, 204);
            this.LogGroupBox.TabIndex = 2;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "log";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(297, 152);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "删除文件";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.Location = new System.Drawing.Point(177, 152);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(100, 30);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "直接打开文件";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Paramslabel
            // 
            this.Paramslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Paramslabel.AutoSize = true;
            this.Paramslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paramslabel.Location = new System.Drawing.Point(177, 104);
            this.Paramslabel.Name = "Paramslabel";
            this.Paramslabel.Size = new System.Drawing.Size(2, 17);
            this.Paramslabel.TabIndex = 4;
            // 
            // ParamsButton
            // 
            this.ParamsButton.Location = new System.Drawing.Point(21, 96);
            this.ParamsButton.Name = "ParamsButton";
            this.ParamsButton.Size = new System.Drawing.Size(139, 30);
            this.ParamsButton.TabIndex = 3;
            this.ParamsButton.Text = "选择替换参数文件";
            this.ParamsButton.UseVisualStyleBackColor = true;
            this.ParamsButton.Click += new System.EventHandler(this.ParamsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(21, 152);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(139, 30);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "生成SQL";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Directorlabel
            // 
            this.Directorlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Directorlabel.AutoSize = true;
            this.Directorlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Directorlabel.Location = new System.Drawing.Point(177, 45);
            this.Directorlabel.Name = "Directorlabel";
            this.Directorlabel.Size = new System.Drawing.Size(2, 17);
            this.Directorlabel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "选择带问号的SQL";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(84, 265);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(0, 15);
            this.labelPath.TabIndex = 4;
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 292);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.LogGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(709, 339);
            this.MinimumSize = new System.Drawing.Size(709, 339);
            this.Name = "SqlForm";
            this.Text = "SQL参数拼接";
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label Paramslabel;
        private System.Windows.Forms.Button ParamsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Directorlabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPath;
    }
}