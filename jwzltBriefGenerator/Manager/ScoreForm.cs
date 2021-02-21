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
    public partial class ScoreForm : Form
    {
        public string filename = "";
        public int department;
        public string departmentName;
        public bool ifScored = false;
        DataTable dt;

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = DataHelper.GetBriefData("操作人", filename, department, departmentName, "", "");
            }
            catch (Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                this.Close();
                return;
            }
            //评分进度 TODO
            departmentText.Text = departmentName;
            //判断是否有评分信息
            if(dt.Columns[dt.Columns.Count - 1].ColumnName != ""
                && Int32.TryParse(dt.Rows[0][dt.Columns.Count - 1].ToString(), out _)
                && Int32.TryParse(dt.Rows[1][dt.Columns.Count - 1].ToString(), out _))
            {
                ifScored = true;
            }
            Reload();
        }

        private void SetViewHeader()
        {

        }

        private void Reload()
        {
            if (dt == null || dt.Rows.Count <= 0)
            {
                MsgBox.ShowError("简报数据文件为空！请检查参数、选择的文件或部门是否正确！");
                this.Close();
                return;
            }

        }
    }
}
