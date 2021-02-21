using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string columnName = combo.SelectedItem.ToString();
            List<string> keywordList = new List<string>();
            List<DataTable> finalResult = new List<DataTable>();
            //遍历数据表找出到底有多少种
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                if(!keywordList.Contains(dt.Rows[i][combo.SelectedIndex].ToString()))
                {
                    keywordList.Add(dt.Rows[i][combo.SelectedIndex].ToString());
                }
            }
            for(int i = 0;i < keywordList.Count;i++)
            {
                DataTable newDt = new DataTable();
                newDt = dt.Clone();
                DataRow[] dr = dt.Select("'"+columnName+"' = '"+keywordList[i]+"'");
                for(int j = 0;j < dr.Length;j++)
                {
                    newDt.ImportRow((DataRow)dr[j]);
                }
                finalResult.Add(newDt);
            }
            //Export
            try
            {
                string file = FileHelper.SaveFileDialog();
                IWorkbook wk = null;
                ISheet sheet = null;
                IRow row = null;//数据行
                ICell cell = null;//数据行中的某列
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                else
                {
                    wk = new XSSFWorkbook();
                }
                for(int i = 0;i < keywordList.Count;i++)
                {
                    sheet = wk.CreateSheet(keywordList[i]);
                    row = sheet.GetRow(0);
                    if (row == null) row = sheet.CreateRow(0);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        cell = row.GetCell(j);
                        if (cell == null)
                        {
                            cell = row.CreateCell(j, CellType.String);
                        }
                        cell.SetCellValue(dt.Columns[j].ColumnName);
                    }
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    {
                        row = sheet.GetRow(j);
                        if (row == null) row = sheet.CreateRow(j);
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            cell = row.GetCell(k);
                            if (cell == null)
                            {
                                cell = row.CreateCell(k, CellType.String);
                            }
                            cell.SetCellValue(dt.Rows[j - 1][k].ToString());
                        }
                    }
                }
                //转为字节数组
                MemoryStream stream = new MemoryStream();
                wk.Write(stream);
                var buf = stream.ToArray();

                //保存为Excel文件  
                using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                }
            }
            catch(Exception ex)
            {
                MsgBox.ShowError(ex.Message);
                return;
            }
            MsgBox.ShowInfo("保存成功!");
        }
    }
}
