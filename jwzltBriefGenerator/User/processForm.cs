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

namespace jwzltBriefGenerator.User
{
    public partial class processForm : Form
    {
        public string username = "";
        public string filename = "";
        public int department;
        public string departmentName;
        public string fromStr, toStr; //从0开始。第1条为0。
        DataTable dt;

        private void processForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = Utils.GetBriefData(username, filename, department, departmentName, fromStr, toStr);
            } 
            catch(Exception ex)
            {
                Utils.ShowTip("提示", ex.Message);
                this.Close();
                return;
            }
            if (fromStr == "") fromStr = "0";
            if (toStr == "") toStr = "0";
            fileLabel.Text = (Convert.ToInt32(fromStr) + 1) + "~" + (Convert.ToInt32(toStr) + 1);
            departmentText.Text = departmentName;
            Reload();
        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //更改简报总览中内容
            totalList.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalList.Items.Add(dt.Rows[i][filterCombo.SelectedIndex].ToString());
            }
        }

        private void totalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            processLabel.Text = (totalList.SelectedIndex + 1) + "/" + totalList.Items.Count;
            singleList.Items.Clear();
            //创建表头
            singleList.Columns.Add("项目名称", 120);
            singleList.Columns.Add("项目内容", 120);
            //加载内容
            singleList.BeginUpdate();
            for(int i = 0;i < dt.Columns.Count;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Columns[i].ColumnName;
                lvi.SubItems.Add(dt.Rows[totalList.SelectedIndex][i].ToString());
                singleList.Items.Add(lvi);
            }
            singleList.EndUpdate();
            singleList.Items[0].Selected = true;
            singleList.Select();
        }

        private void singleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (singleList.SelectedIndices != null && singleList.SelectedIndices.Count > 0)
            {
                singleNameText.Text = singleList.SelectedItems[0].SubItems[0].Text;
                singleContentText.Text = singleList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void Reload(int save = 0) //刷新, save表示是否保存,0不保存,1保存到combo,2保存到totalList,3保存到singleList
        {
            if(dt == null || dt.Rows.Count <= 0)
            {
                Utils.ShowTip("错误", "简报数据文件为空！请检查参数、选择的文件或院系是否正确！");
                this.Close();
                return;
            }
            int saveCombo = 0, saveTotalList = 0, saveSingleList = 0;
            switch(save)
            {
                case 3:
                    //保存到singleList
                    saveSingleList = singleList.SelectedIndices[0];
                    goto case 2;
                case 2:
                    //保存到totalList
                    saveTotalList = totalList.SelectedIndex;
                    goto case 1;
                case 1:
                    //保存到Combo
                    saveCombo = filterCombo.SelectedIndex;
                    break;
            }
            filterCombo.Items.Clear();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                filterCombo.Items.Add(dt.Columns[i].ColumnName);
            }
            filterCombo.SelectedIndex = 0;
            totalList.SelectedIndex = 0;
            switch(save) //TODO: 优化
            {
                case 1:
                    filterCombo.SelectedIndex = saveCombo;
                    break;
                case 2:
                    filterCombo.SelectedIndex = saveCombo;
                    totalList.SelectedIndex = saveTotalList;
                    break;
                case 3:
                    filterCombo.SelectedIndex = saveCombo;
                    totalList.SelectedIndex = saveTotalList;
                    singleList.Items[saveSingleList].Selected = true;
                    singleList.Select();
                    break;
            }
            processLabel.Text = (totalList.SelectedIndex + 1) + "/" + totalList.Items.Count;
        }

        private void saveNowContent() //保存当前项目
        {
            //刷新dt中值
            int nowSelectedRow = totalList.SelectedIndex;
            int nowSelectedColumnIndex = singleList.SelectedIndices[0];
            string nowSelectedColumnContent = singleContentText.Text;
            dt.Rows[nowSelectedRow][nowSelectedColumnIndex] = nowSelectedColumnContent;
            Reload(3);
        }

        private void saveTotal() //保存整个dt，写回excel
        {
            saveNowContent();
            Utils.DataTableToXlsx(dt, filename, department, departmentName);
        }

        private void singlePrevButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if(singleList.SelectedIndices[0] == 0)
            {
                if (singleList.SelectedIndices[0] == singleList.Items.Count - 1)
                {
                    if (Utils.ShowQuestion("提示", "已经是第一个项了，是否要回到上一条简报？"))
                    {
                        prevButton.PerformClick();
                    }
                    return;
                }
            }
            singleList.Items[singleList.SelectedIndices[0] - 1].Selected = true;
            singleList.Select();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveTotal();
            }
            catch(Exception ex)
            {
                Utils.ShowTip("失败", "保存失败: "+ex.Message);
            }
            this.Close();
            return;
        }

        private void singleNextButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if (singleList.SelectedIndices[0] == singleList.Items.Count - 1)
            {
                if(Utils.ShowQuestion("提示", "已经是最后一个项了，是否要进入下一条简报？"))
                {
                    nextButton.PerformClick();
                }
                return;
            }
            singleList.Items[singleList.SelectedIndices[0] + 1].Selected = true;
            singleList.Select();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(totalList.Items.Count == 1)
            {
                Utils.ShowTip("提示", "仅有一条简报，无法删除!");
                return;
            }
            if(Utils.ShowQuestion("询问", "确认要删除本条记录吗？"))
            {
                dt.Rows[totalList.SelectedIndex].Delete();
                Utils.ShowTip("提示", "删除成功!");
                Reload(1);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if(totalList.SelectedIndex == 0)
            {
                Utils.ShowTip("提示", "已经是第一个简报了。");
                return;
            }
            totalList.SelectedIndex -= 1;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if (totalList.SelectedIndex == totalList.Items.Count - 1)
            {
                Utils.ShowTip("提示", "已经是最后一个简报了。");
                return;
            }
            totalList.SelectedIndex += 1;
        }

        public processForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
    }
}
