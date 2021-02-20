using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jwzltBriefGenerator.Manager
{
    public partial class ResizeForm : Form
    {
        public string filename = "";
        DataTable dt;

        public ResizeForm()
        {
            InitializeComponent();
        }

        private void ResizeForm_Load(object sender, EventArgs e)
        {
            dt = DataHelper.CsvToDataTable(filename);
            /*try
            {
                dt = DataHelper.CsvToDataTable(filename);
            }
            catch (Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                this.Close();
                return;
            }*/
            for (int i = 0;i < dt.Columns.Count;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Columns[i].ColumnName;
                lvi.SubItems.Add(dt.Rows[0][i].ToString());
                columnList.Items.Add(lvi);
                filterColumnCombo.Items.Add(dt.Columns[i].ColumnName);
            }
            filenameLabel.Text = filename;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}