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
            this.decMessageLabel.Text = "";
            string base64Text = this.richTextBase64.Text;
            if (string.IsNullOrEmpty(base64Text))
            {
                return;
            }

            string xml;
            try {
                xml = Base64DecUtil.DecBase64(base64Text);
            }
            catch (Exception ex)
            {
                this.decMessageLabel.Text = ex.Message;
                xml = "";
            }
            
            if (string.IsNullOrEmpty(xml))
            {
                MessageBox.Show(Properties.Resources.messageInputISBase64);

            }
            else {
                this.richTextBoxXML.Text = xml;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string xml = this.richTextBoxXML.Text;
            if (!string.IsNullOrEmpty(xml)) {
                this.decMessageLabel.Text = "";
                Clipboard.SetDataObject(xml);
                MessageBox.Show(Properties.Resources.messageCopyOk);
            }
           
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            this.richTextBoxXML.Text = "";
            this.richTextBase64.Text = "";
            this.decMessageLabel.Text = "";
        }

        private void RichTextBase64_MouseEnter(object sender, EventArgs e)
        {
            StringUtils.CleanFormat();
        }
    }
}
