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


        private void AddButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = Properties.Resources.fileFromat;
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Directorlabel.Text = openFileDialog.FileName;          //显示文件路径
                    this.MessageLabel.Text = Properties.Resources.messageLoadSQLOK;
                }

            }    //显示选择文件对话框

                
        }

        private void ParamsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = Properties.Resources.fileFromat;
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Paramslabel.Text = openFileDialog.FileName;          //显示文件路径
                    this.MessageLabel.Text = Properties.Resources.messageLoadParamOk;
                }
            } 
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String sqlFilePath = this.Directorlabel.Text;
            String parFilePath = this.Paramslabel.Text;
            if (string.IsNullOrEmpty(sqlFilePath) || string.IsNullOrEmpty(parFilePath) )
            {
                this.MessageLabel.Text = Properties.Resources.messageLoadParamErr;
                return;
            }
            if (!File.Exists(sqlFilePath))
            {
                MessageBox.Show(Properties.Resources.messageNotSqlPath);
                return;
            }
            if (!File.Exists(parFilePath))
            {
                MessageBox.Show(Properties.Resources.messageNotSqlParam);
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
                    this.MessageLabel.Text = Properties.Resources.messageLoadSQLErr;
                    return;
                }
                srp = new StreamReader(parFilePath, System.Text.Encoding.UTF8);
                String praText = srp.ReadToEnd().TrimStart();
                String sqlTxt = StringUtils.GetFullSql(sqlText, praText);
                SaveFile(sqlTxt);
                Clipboard.SetDataObject(sqlTxt);
                MessageBox.Show(Properties.Resources.messageAppendOk);
            }
            catch (IOException ex)
            {
                this.MessageLabel.Text = ex.Message;
                MessageBox.Show(Properties.Resources.messageSaveErr);
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
            long nowTime = DateTime.Now.ToFileTime();
            string fileName = "sql" + nowTime + ".txt";
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(sqlTxt.Trim());
                sw.Flush();
                MessageLabel.Text = Properties.Resources.messageSaveOk;

                FileInfo fileInfo = new FileInfo(fileName);
                this.labelPath.Text = fileInfo.FullName;
  
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
                MessageBox.Show(Properties.Resources.messagePathNotNull, Properties.Resources.messageType);
                return;
            }
            //先判断文件是否存在，不存在则提示 
            if (!System.IO.File.Exists(this.labelPath.Text))
            {
                MessageBox.Show(Properties.Resources.messageNotFile, Properties.Resources.messageType);
                return;
            }
            //存在则打开 
            FileInfo file = new FileInfo(this.labelPath.Text);
            System.Diagnostics.Process.Start("explorer.exe", file.FullName);

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.labelPath.Text))
            {
                MessageBox.Show(Properties.Resources.messagePathNotNull, Properties.Resources.messageType);
                return;
            }
            if (!File.Exists(this.labelPath.Text))
            {
                MessageBox.Show(Properties.Resources.messageNotFile);
                return;
            }
            try {
                File.Delete(this.labelPath.Text);
                FileInfo fileInfo = new FileInfo(this.labelPath.Text);
                
                MessageBox.Show(fileInfo.FullName + Properties.Resources.messageDelOk, Properties.Resources.messageType);
            } catch (IOException ioe) {
                MessageBox.Show(ioe.Message, Properties.Resources.messageType);
            }
            
        }
    }
}
