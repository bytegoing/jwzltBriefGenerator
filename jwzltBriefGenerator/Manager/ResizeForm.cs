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
            columnList.Columns.Add("列名称", 120);
            columnList.Columns.Add("预览", 120);
            columnList.BeginUpdate();
            for (int i = 0;i < dt.Columns.Count;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Columns[i].ColumnName;
                lvi.SubItems.Add(dt.Rows[0][i].ToString());
                columnList.Items.Add(lvi);
                filterColumnCombo.Items.Add(dt.Columns[i].ColumnName);
            }
            columnList.EndUpdate();
            filenameLabel.Text = filename;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataTable newDt = new DataTable();
            if(columnList.SelectedItems.Count <= 0)
            {
                MsgBox.ShowError("请至少选择一列需要保留的数据！");
                return;
            }
            for(int i = 0;i < columnList.SelectedItems.Count;i++)
            {
                int nowSelectedIndex = columnList.SelectedItems[i].Index;
                newDt.Columns.Add(new DataColumn(dt.Columns[nowSelectedIndex].ColumnName, typeof(string)));
                for(int j = 0;j < dt.Rows.Count;j++)
                {
                    if(newDt.Rows.Count > j)
                    {
                        //存在该行
                        newDt.Rows[j][newDt.Columns.Count - 1] = dt.Rows[j][nowSelectedIndex];
                    }
                    else
                    {
                        //不存在该行
                        newDt.Rows.Add(dt.Rows[j][nowSelectedIndex]);
                    }
                }
            }
            if(filterColumnCombo.SelectedIndex != -1)
            {
                for (int i = 0; i < newDt.Rows.Count; i++)
                {
                    if (newDt.Rows[i][filterColumnCombo.SelectedIndex].ToString() != filterText.Text)
                    {
                        newDt.Rows[i].Delete();
                    }
                }
            }
            try
            {
                DataHelper.DataTableToCsv(newDt, filename);
            }
            catch(Exception ex)
            {
                MsgBox.ShowError(ex.Message);
                return;
            }
            MsgBox.ShowInfo("成功!");
            this.Close();
        }
    }
}