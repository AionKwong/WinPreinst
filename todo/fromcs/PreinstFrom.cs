using System;
using System.Windows.Forms;
using WinPreinst.todo.fromcs;

namespace WinPreinst
{
    public partial class preinst : Form
    {
        public preinst()
        {
            InitializeComponent();
        }

        private void DataSourTool_Click(object sender, EventArgs e)
        {
            DataSoursFrom dataSoursFrom = new DataSoursFrom
            {
                TopLevel = false
            };
            this.flowLayoutPanelMain.Controls.Add(dataSoursFrom);
            dataSoursFrom.Show();
        }

        private void KettleTool_Click(object sender, EventArgs e)
        {
            KettleForm kettleForm = new KettleForm
            {
                TopLevel = false
            };
            this.flowLayoutPanelMain.Controls.Add(kettleForm);
            kettleForm.Show();
        }

        private void SqlAppendTool_Click(object sender, EventArgs e)
        {
            Form sqlAppendForm = new SqlForm
            {
                TopLevel = false
            };
            this.flowLayoutPanelMain.Controls.Add(sqlAppendForm);
            sqlAppendForm.Show();
        }

        private void DecomToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void XMLFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form xmlFormatForm = new XMLFormatForm
            {
                TopLevel = false
            };
            this.flowLayoutPanelMain.Controls.Add(xmlFormatForm);
            xmlFormatForm.Show();
        }

    }
}
