using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using WinPreinst.todo.util;

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

        private void ButtonCiphJAVA_Click(object sender, EventArgs e)
        {
            if (!NetJavaRun.CheckFile()) {
                MessageBox.Show("请检查执行程序目录下是否存在DesPassWord.class文件");
                return;
            }
            string ciphText =  this.richTextProcl.Text;
            if (string.IsNullOrEmpty(ciphText))
            {
                return;
            }

            string ciphReslut = NetJavaRun.Exec("1", ciphText);
            this.richTextCiph.Text = ciphReslut;

        }

        private void BottonProclJAVA_Click(object sender, EventArgs e)
        {
            if (!NetJavaRun.CheckFile())
            {
                MessageBox.Show("请检查执行程序目录下是否存在DesPassWord.class文件");
                return;
            }
            string proclText = this.richTextCiph.Text;
            if (string.IsNullOrEmpty(proclText))
            {
                return;
            }
            string proclReslut = NetJavaRun.Exec("2", proclText);
            this.richTextProcl.Text = proclReslut;
        }
    }
}
