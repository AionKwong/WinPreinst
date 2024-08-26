using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WinPreinst.todo.fromcs
{
    public partial class XMLFormatForm : Form
    {
        
        private const string MSG_01 = "未输入XML字符串";

        public XMLFormatForm()
        {
            InitializeComponent();
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputXml = this.richTextBoxIn.Text;
            if (string.IsNullOrEmpty(inputXml))
            {
                this.XMLMessageLabel.Text = MSG_01;
                return;
            }

            XmlTextWriter xtw = null;
            try {
                XmlDocument xd = new XmlDocument() {
                    XmlResolver = null
                };
                StringReader sreader = new StringReader(inputXml);
                XmlReaderSettings xrs = new XmlReaderSettings() { XmlResolver = null };
                XmlReader reader = XmlReader.Create(sreader, xrs);
                xd.Load(reader);

                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                xtw = new XmlTextWriter(sw)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 1,
                    IndentChar = '\t'
                };
                xd.WriteTo(xtw);
                xtw.Flush();
                this.richTextBoxOut.Text = sb.ToString();
                Clipboard.SetDataObject(sb.ToString());
            } catch (IOException ex) {
                this.XMLMessageLabel.Text = ex.Message;
                MessageBox.Show("失败");
            }
            finally
            {
                if (xtw != null) {
                    xtw.Close();
                }
                    
            }
            
        }

        private void OpenXMLButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelOpenPath.Text))
            {
                MessageBox.Show("路径不能为空！", "操作提示");
                return;
            }
            //先判断文件是否存在，不存在则提示 
            if (!System.IO.File.Exists(this.labelOpenPath.Text))
            {
                MessageBox.Show("指定文件不存在！", "操作提示");
                return;
            }
            //存在则打开 
            System.Diagnostics.Process.Start("explorer.exe", this.labelOpenPath.Text);
        }

        private void DeleteXMLButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelOpenPath.Text))
            {
                MessageBox.Show("路径不能为空！", "操作提示");
                return;
            }
            if (!File.Exists(this.labelOpenPath.Text))
            {
                MessageBox.Show("已经被删除!");
                return;
            }
            try
            {
                File.Delete(this.labelOpenPath.Text);
                MessageBox.Show(this.labelOpenPath.Text + "删除成功！", "操作提示");
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "操作提示");
            }

        }


        private void SaveFile(String xmlText)
        {
            FileStream fs;
            StreamWriter sw = null;
            string nowTime = DateTime.Now.ToFileTime().ToString();
            string fileName = "XML" + nowTime + ".txt";
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(xmlText.Trim());
                sw.Flush();
                this.XMLMessageLabel.Text = "已保存文件，请前往查看-->";
                
                this.labelOpenPath.Text = Environment.CurrentDirectory + Path.AltDirectorySeparatorChar + fileName;

            }
            catch (IOException ex)
            {
                this.XMLMessageLabel.Text = ex.Message;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }

            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string xml = this.richTextBoxOut.Text;
            if (!string.IsNullOrEmpty(xml)) 
            {
                SaveFile(xml);
            }
        }

        private void RichTextBoxIn_MouseEnter(object sender, EventArgs e)
        {
            StringUtils.CleanFormat();
        }
    }
}
