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
    public partial class ExportForm : Form
    {
        public string filename = "";
        DataTable dt;

        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = DataHelper.CsvToDataTable(filename);
            }
            catch (Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                this.Close();
                return;
            }
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                combo.Items.Add(dt.Columns[i].ColumnName);
            }
            filenameLabel.Text = filename;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if(combo.SelectedIndex == -1)
            {
                MsgBox.ShowError("请选择1.工作表名称列!");
                return;
            }

        }
    }
}
