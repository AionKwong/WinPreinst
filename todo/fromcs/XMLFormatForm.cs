using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinPreinst.todo.fromcs
{
    public partial class XMLFormatForm : Form
    {
        private const string fix_str = "\\";

        public XMLFormatForm()
        {
            InitializeComponent();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };     //显示选择文件对话框

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.DirectorXMLlabel.Text = openFileDialog.FileName;          //显示文件路径
                this.XMLMessageLabel.Text = "已加载需格式化的XML文件";
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputPath = this.DirectorXMLlabel.Text;
            if (string.IsNullOrEmpty(inputPath))
            {
                this.XMLMessageLabel.Text = "未选择需要格式化的XML文件";
                return;
            }

            XmlTextWriter xtw = null;
            try {
                XmlDocument xd = new XmlDocument() { XmlResolver = null };
               // xd.Load(inputPath);
                XmlReader reader = XmlReader.Create(inputPath, new XmlReaderSettings() { XmlResolver = null });
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
                SaveFile(sb.ToString());
                Clipboard.SetDataObject(sb.ToString());
                MessageBox.Show("格式化XML完成并复制到剪切板");
                
            } catch (IOException ex) {
                this.XMLMessageLabel.Text = ex.Message;
                MessageBox.Show("失败");
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
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
                this.XMLMessageLabel.Text = "格式完成: 请前往查看文件-->";
                this.labelOpenPath.Text = Environment.CurrentDirectory + fix_str + fileName;

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
    }
}
