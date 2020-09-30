using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WinPreinst
{
    public partial class SqlForm : Form
    {
        public SqlForm()
        {
            InitializeComponent();
        }

        private const string fix_str = "\\";

        private void AddButton_Click(object sender, EventArgs e)
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
                this.Directorlabel.Text = openFileDialog.FileName;          //显示文件路径
                this.MessageLabel.Text = "带问号的SQL加载成功";
            }
        }

        private void ParamsButton_Click(object sender, EventArgs e)
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
                this.Paramslabel.Text = openFileDialog.FileName;          //显示文件路径
                this.MessageLabel.Text = "参数加载成功";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String sqlFilePath = this.Directorlabel.Text;
            String parFilePath = this.Paramslabel.Text;
            if (string.IsNullOrEmpty(sqlFilePath) || string.IsNullOrEmpty(parFilePath) )
            {
                this.MessageLabel.Text = "未正确选择必要参数";
                return;
            }
            if (!File.Exists(sqlFilePath))
            {
                MessageBox.Show("SQL文件不存在!");
                return;
            }
            if (!File.Exists(parFilePath))
            {
                MessageBox.Show("参数文件不存在!");
                return;
            }
            StreamReader sr = null;
            StreamReader srp = null;
            try
            {
                sr = new StreamReader(sqlFilePath, System.Text.Encoding.UTF8);
                String sqlText = sr.ReadToEnd().TrimStart();
                if (sqlText.IndexOf('?') < 0)
                {
                    this.MessageLabel.Text = "未正确选择带问号的SQL语句";
                    return;
                }
                srp = new StreamReader(parFilePath, System.Text.Encoding.UTF8);
                String praText = srp.ReadToEnd().TrimStart();
                String sqlTxt = StringUtils.GetFullSql(sqlText, praText);
                SaveFile(sqlTxt);
                Clipboard.SetDataObject(sqlTxt);
                MessageBox.Show("生成成功并复制到剪切板");
            }
            catch (IOException ex)
            {
                this.MessageLabel.Text = ex.Message;
                MessageBox.Show("失败");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (srp != null)
                {
                    srp.Close();
                }
            }

        }

        private void SaveFile(String sqlTxt)
        {
            FileStream fs;
            StreamWriter sw = null;
            string nowTime = DateTime.Now.ToFileTime().ToString();
            string fileName = "sql" + nowTime + ".txt";
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(sqlTxt.Trim());
                sw.Flush();
                this.MessageLabel.Text = "成功生成: 请前往查看文件-->";
                this.labelPath.Text = Environment.CurrentDirectory + fix_str + fileName;
  
            }
            catch (IOException ex)
            {
                this.MessageLabel.Text = ex.Message;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
 
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelPath.Text))
            {
                MessageBox.Show("路径不能为空！", "操作提示");
                return;
            }
            //先判断文件是否存在，不存在则提示 
            if (!System.IO.File.Exists(this.labelPath.Text))
            {
                MessageBox.Show("指定文件不存在！", "操作提示");
                return;
            }
            //存在则打开 
            System.Diagnostics.Process.Start("explorer.exe", this.labelPath.Text);

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelPath.Text))
            {
                MessageBox.Show("路径不能为空！", "操作提示");
                return;
            }
            if (!File.Exists(this.labelPath.Text))
            {
                MessageBox.Show("已经被删除!");
                return;
            }
            try {
                File.Delete(this.labelPath.Text);
                MessageBox.Show(this.labelPath.Text+"删除成功！", "操作提示");
            } catch (IOException ioe) {
                MessageBox.Show(ioe.Message, "操作提示");
            }
            
        }
    }
}
