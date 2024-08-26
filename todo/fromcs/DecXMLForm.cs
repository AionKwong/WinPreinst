using System;
using System.Windows.Forms;
using WinPreinst.todo.util;

namespace WinPreinst.todo.fromcs
{
    public partial class DecXMLForm : Form
    {
        public DecXMLForm()
        {
            InitializeComponent();
        }

        private void DecButton_Click(object sender, EventArgs e)
        {
            string base64Text = this.richTextBase64.Text;
            if (string.IsNullOrEmpty(base64Text))
            {
                return;
            }
            string xml = Base64DecUtil.DecBase64(base64Text);
            if (string.IsNullOrEmpty(xml))
            {
                MessageBox.Show("请确认输入是否为base64字符串");
            }
            else {
                this.richTextBoxXML.Text = xml;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string xml = this.richTextBoxXML.Text;
            if (string.IsNullOrEmpty(xml)) { 
            }
            Clipboard.SetDataObject(xml);
            MessageBox.Show("已复制到剪切板");
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            this.richTextBoxXML.Text = "";
            this.richTextBase64.Text = "";
        }

        private void RichTextBase64_MouseEnter(object sender, EventArgs e)
        {
            StringUtils.CleanFormat();
        }
    }
}
