using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinPreinst
{
    public partial class DataSoursFrom : Form
    {
        public DataSoursFrom()
        {
            InitializeComponent();
        }

        private void BottonProcl_Click(object sender, EventArgs e)
        {
            string keyText = this.textKey.Text;
            if (string.IsNullOrEmpty(keyText))
            {
                return;
            }

            string ciphText = this.richTextCiph.Text;
            if (string.IsNullOrEmpty(ciphText))
            {
                return;
            }
            DesPassUtil.def_key = keyText;
            string proclText = DesPassUtil.DecryPassword(ciphText);
            //string proclText = DesPassUtil.DecryptDES(ciphText);
            this.richTextProcl.Text = proclText;
        }

        private void ButtonCiph_Click(object sender, EventArgs e)
        {
            string keyText = this.textKey.Text;
            if (string.IsNullOrEmpty(keyText))
            {
                return;
            }
            string proclText = this.richTextProcl.Text;
            if (string.IsNullOrEmpty(proclText))
            {
                return;
            }

            DesPassUtil.def_key = keyText;
            string ciphText = DesPassUtil.EncryPassword(proclText);
            //string ciphText = DesPassUtil.EncryptDES(proclText);
            this.richTextCiph.Text = ciphText;

        }
    }
}
