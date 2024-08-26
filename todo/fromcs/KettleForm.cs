using System;
using System.Windows.Forms;

namespace WinPreinst
{
    public partial class KettleForm : Form
    {
        public KettleForm()
        {
            InitializeComponent();
        }

        /**
        *  解密
        * */
        private void BottonProclKettle_Click(object sender, EventArgs e)
        {
            string ciphText = this.richTextCiphKettle.Text;
            if (string.IsNullOrEmpty(ciphText))
            {
                return;
            }
            string result = KettlePassUtil.DecryptPassword(ciphText);
            this.richTextProclKettle.Text = result;
        }

        /**
         *  加密
         * */
        private void ButtonCiphKettle_Click(object sender, EventArgs e)
        {
            string proclText = this.richTextProclKettle.Text;
            if (string.IsNullOrEmpty(proclText))
            {
                return;
            }
            string result = KettlePassUtil.EncryptPassword(proclText);
            this.richTextCiphKettle.Text = result;
        }

        private void RichTextProclKettle_MouseEnter(object sender, EventArgs e)
        {
            StringUtils.CleanFormat();
        }
    }
}
