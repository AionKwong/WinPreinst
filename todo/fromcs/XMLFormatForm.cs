using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WinPreinst.todo.fromcs
{
    public partial class XMLFormatForm : Form
    {

        public XMLFormatForm()
        {
            InitializeComponent();
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputXml = this.richTextBoxIn.Text;
            if (string.IsNullOrEmpty(inputXml))
            {
                this.XMLMessageLabel.Text = Properties.Resources.messageNotInputXML;
                return;
            }

            XmlTextWriter xtw = null;
            try {
                XmlDocument xd = new XmlDocument() {
                    XmlResolver = null
                };
                StringReader sreader = new StringReader(inputXml);
                XmlReaderSettings xrs = new XmlReaderSettings() { XmlResolver = null };
                using (XmlReader reader = XmlReader.Create(sreader, xrs)) {
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
                }
                
            } catch (IOException ex) {
                this.XMLMessageLabel.Text = ex.Message;
                MessageBox.Show(Properties.Resources.messageFromatErr, Properties.Resources.messageType);
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
                MessageBox.Show(Properties.Resources.messagePathNotNull, Properties.Resources.messageType);
                return;
            }
            //先判断文件是否存在，不存在则提示 
            if (!File.Exists(this.labelOpenPath.Text))
            {
                MessageBox.Show(Properties.Resources.messageNotFile, Properties.Resources.messageType);
                return;
            }
            FileInfo file = new FileInfo(this.labelOpenPath.Text);
            //存在则打开 
            System.Diagnostics.Process.Start("explorer.exe", file.FullName);
        }

        private void DeleteXMLButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelOpenPath.Text))
            {
                MessageBox.Show(Properties.Resources.messagePathNotNull, Properties.Resources.messageType);
                return;
            }
            if (!File.Exists(this.labelOpenPath.Text))
            {
                MessageBox.Show(Properties.Resources.messageNotFile);
                return;
            }
            try
            {
                File.Delete(this.labelOpenPath.Text);
                FileInfo fileInfo = new FileInfo(this.labelOpenPath.Text);
                MessageBox.Show(fileInfo.FullName + Properties.Resources.messageDelOk, Properties.Resources.messageType);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, Properties.Resources.messageType);
            }

        }


        private void SaveFile(String xmlText)
        {
            FileStream fs;
            StreamWriter sw = null;
            long nowTime = DateTime.Now.ToFileTime();
            string fileName = "XML" + nowTime + ".txt";
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(xmlText.Trim());
                sw.Flush();
                
                XMLMessageLabel.Text = Properties.Resources.messageSaveOk;
                FileInfo fileInfo = new FileInfo(fileName);
                this.labelOpenPath.Text = fileInfo.FullName;

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
