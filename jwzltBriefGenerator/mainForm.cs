using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jwzltBriefGenerator.User;
using NPOI.XSSF.UserModel;
using NPOI.XWPF.UserModel;

namespace jwzltBriefGenerator
{
    public partial class mainForm : Form
    {
        browserForm browser;
        public mainForm()
        {
            InitializeComponent();
        }

        private void userChooseFileButton_Click(object sender, EventArgs e)
        {
            string userFilename = FileHelper.OpenFileDialog("请选择简报数据文件", "xlsx文件|*.xlsx");
            if (userFilename != "")
            {
                this.userFilename.Text = userFilename;
            }
            else
            {
                MsgBox.ShowError("请选择有效文件！");
                return;
            }
            userDepartmentCombo.Items.Clear(); //清空Combo中的所有项
            //开始读取Sheet名称
            XSSFWorkbook workbook;
            try
            {
                using (FileStream stream = File.OpenRead(userFilename))
                {
                    workbook = new XSSFWorkbook(stream);
                }
            }
            catch(Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                this.userFilename.Text = "";
                return;
            }
            int SheetCount = workbook.NumberOfSheets;//获取表的数量
            for (int i = 0; i < SheetCount; i++) //逐个加入Combo
            {
                userDepartmentCombo.Items.Add(workbook.GetSheetName(i));
            }
            workbook.Clear(); //清空workbook，释放内存。
        }

        private void userProcessBriefButton_Click(object sender, EventArgs e)
        {
            User.processForm pf = new User.processForm();
            pf.fromStr = userProcessFromText.Text;
            pf.toStr = userProcessToText.Text;
            pf.username = username.Text;
            pf.filename = userFilename.Text;
            pf.department = userDepartmentCombo.SelectedIndex;
            pf.departmentName = userDepartmentCombo.SelectedItem.ToString();
            pf.ShowDialog();
        }

        private void userExportBriefDataButton_Click(object sender, EventArgs e)
        {
            int department = userDepartmentCombo.SelectedIndex;
            string filename = FileHelper.SaveFileDialog();
            if(filename == "")
            {
                MsgBox.ShowError("请选择源数据文件");
                return;
            }
            DataTable dt = DataHelper.XlsxToDataTable(userFilename.Text, department);
            try
            {
                DataHelper.DataTableToXlsx(dt, filename, department, userDepartmentCombo.SelectedItem);
            } 
            catch(Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                return;
            }
        }

        private void userExportBriefDocButton_Click(object sender, EventArgs e)
        {
            DataTable dt;
            try
            {
                dt = DataHelper.GetBriefData(username.Text, userFilename.Text, userDepartmentCombo.SelectedIndex, userDepartmentCombo.SelectedItem, userProcessFromText.Text, userProcessToText.Text);
            }
            catch (Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                return;
            }
            Dictionary<string, object> data = new Dictionary<string, object>();
            for(int i = 0;i < dt.Columns.Count;i++)
            {
                //data.Add(dt.Columns[i].ColumnName, dt.Rows[0][i].ToString());
                data.Add(DataHelper.convertNumberToExcelColumn(i), dt.Rows[0][i].ToString());
            }
            data.Add("year", DateTime.Now.Year+"");
            data.Add("month", DateTime.Now.Month+"");
            data.Add("day", DateTime.Now.Day+"");
            data.Add("name", username.Text);
            List<Dictionary<string, string>> record = new List<Dictionary<string, string>>();
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                Dictionary<string, string> tmpd = new Dictionary<string, string>();
                tmpd.Add("no", (i + 1)+"");
                for(int j = 0;j < dt.Columns.Count;j++)
                {
                    //tmpd.Add(dt.Columns[j].ColumnName, dt.Rows[i][j].ToString());
                    tmpd.Add(DataHelper.convertNumberToExcelColumn(j), dt.Rows[i][j].ToString());
                }
                record.Add(tmpd);
            }
            data.Add("briefs", record);
            string infoJson = JsonHelper.SerializeDictionaryToJsonString<string, object>(data);
            infoJson = Convert.ToBase64String(Encoding.UTF8.GetBytes(infoJson));
            try
            {
                Console.WriteLine("Getting new Browser...");
                browser.url = "file://" + System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "web/generator.html";
                browser.str = infoJson;
                browser.ShowDialog();
                //bf.Close();
            }
            catch (Exception ex)
            {
                MsgBox.ShowError("保存失败: " + ex.Message);
                return;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            browser = new browserForm();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            browser.Dispose();
            Dispose();
            Application.Exit();
        }

        private void originDataFileButton_Click(object sender, EventArgs e)
        {
            string originFilename = FileHelper.OpenFileDialog("请选择原始简报数据文件", "csv文件|*.csv");
            if (originFilename != "")
            {
                this.originDataFileText.Text = originFilename;
            }
            else
            {
                MsgBox.ShowError("请选择有效文件！");
                return;
            }
        }

        private void editOriginDataButton_Click(object sender, EventArgs e)
        {
            Manager.ResizeForm rf = new Manager.ResizeForm();
            if(originDataFileText.Text != "")
            {
                rf.filename = originDataFileText.Text;
                rf.ShowDialog();
            }
            else
            {
                MsgBox.ShowError("请选择原始简报数据文件!");
                return;
            }
        }
    }
}
