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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jwzltBriefGenerator.User
{
    public partial class processForm : Form
    {
        enum SAVE_PROGRESS {DoNotSave, SingleList, TotalList, Combo}; //重新载入数据时保存**进度**到哪里?

        public string username = "";
        public string filename = "";
        public int department;
        public string departmentName;
        public string fromStr, toStr; //从0开始。第1条为0。
        public int customColumnNumber = 0; //0代表无自定义字段
        DataTable dt;

        private void processForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = XLSXHelper.GetBriefData(username, filename, department, departmentName, fromStr, toStr);
            } 
            catch(Exception ex)
            {
                MsgBox.ShowError("错误: " + ex.Message);
                this.Close();
                return;
            }
            if (fromStr == "") fromStr = "0";
            if (toStr == "") toStr = "0";
            fileLabel.Text = (Convert.ToInt32(fromStr) + 1) + "~" + (Convert.ToInt32(toStr) + 1);
            departmentText.Text = departmentName;
            //判断自定义列个数，目前最大支持2
            while (dt.Columns[dt.Columns.Count - customColumnNumber - 1].ColumnName != "" 
                && dt.Rows[2][dt.Columns.Count - customColumnNumber - 1].ToString() == ""
                && dt.Rows[3][dt.Columns.Count - customColumnNumber - 1].ToString() == "")
                customColumnNumber++;
            if (customColumnNumber == 0)
            {
                dt.Columns.Add("自定义1");
                dt.Columns.Add("自定义2");
            }
            else
            {
                if (customColumnNumber > 2) customColumnNumber = 2;
                c1Text.Text = Regex.Replace(dt.Rows[0][dt.Columns.Count - 2].ToString(), @"<br>", System.Environment.NewLine);
                c2Text.Text = Regex.Replace(dt.Rows[0][dt.Columns.Count - 1].ToString(), @"<br>", System.Environment.NewLine);
                //c1Text.Text = dt.Rows[0][dt.Columns.Count - 2].ToString();
                //c2Text.Text = dt.Rows[0][dt.Columns.Count - 1].ToString();
            }
            Console.WriteLine("Get customColumn: " + customColumnNumber);
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
            for(int i = 0;i < dt.Columns.Count - customColumnNumber;i++)
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
                singleContentText.Text = Regex.Replace(singleList.SelectedItems[0].SubItems[1].Text, @"<br>", System.Environment.NewLine);
                //singleContentText.Text = singleList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void Reload(SAVE_PROGRESS saveType = SAVE_PROGRESS.DoNotSave) //刷新, save表示是否保存,0不保存,1保存到combo,2保存到totalList,3保存到singleList
        {
            if(dt == null || dt.Rows.Count <= 0)
            {
                MsgBox.ShowError("简报数据文件为空！请检查参数、选择的文件或院系是否正确！");
                this.Close();
                return;
            }
            int saveCombo = 0, saveTotalList = 0, saveSingleList = 0;
            switch(saveType)
            {
                case SAVE_PROGRESS.SingleList:
                    //保存到singleList
                    saveSingleList = singleList.SelectedIndices[0];
                    goto case SAVE_PROGRESS.TotalList;
                case SAVE_PROGRESS.TotalList:
                    //保存到totalList
                    saveTotalList = totalList.SelectedIndex;
                    goto case SAVE_PROGRESS.Combo;
                case SAVE_PROGRESS.Combo:
                    //保存到Combo
                    saveCombo = filterCombo.SelectedIndex;
                    break;
            }
            filterCombo.Items.Clear();
            for (int i = 0; i < dt.Columns.Count - customColumnNumber; i++)
            {
                filterCombo.Items.Add(dt.Columns[i].ColumnName);
            }
            filterCombo.SelectedIndex = 0;
            totalList.SelectedIndex = 0;
            switch (saveType) //TODO: 优化
            {
                case SAVE_PROGRESS.Combo:
                    filterCombo.SelectedIndex = saveCombo;
                    break;
                case SAVE_PROGRESS.TotalList:
                    filterCombo.SelectedIndex = saveCombo;
                    totalList.SelectedIndex = saveTotalList;
                    break;
                case SAVE_PROGRESS.SingleList:
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
            string nowSelectedColumnContent = Regex.Replace(singleContentText.Text, System.Environment.NewLine, @"<br>");
            //string nowSelectedColumnContent = singleContentText.Text;
            dt.Rows[nowSelectedRow][nowSelectedColumnIndex] = nowSelectedColumnContent;
            if (c1Text.Text != "" || c2Text.Text != "")
            {
                customColumnNumber = 2;
            }
            if (customColumnNumber == 0)
            {
                if (c1Text.Text != "" || c2Text.Text != "")
                {
                    customColumnNumber = 2;
                }
            }
            /*c2Text.Text = c2Text.Text.Replace("\r\n", "\n");
            c1Text.Text = c1Text.Text.Replace("\r\n", "\n");*/
            dt.Rows[0][dt.Columns.Count - 1] = Regex.Replace(c2Text.Text, System.Environment.NewLine, "<br>");
            dt.Rows[0][dt.Columns.Count - 2] = Regex.Replace(c1Text.Text, System.Environment.NewLine, "<br>");
            /*dt.Rows[0][dt.Columns.Count - 1] = c2Text.Text;
            dt.Rows[0][dt.Columns.Count - 2] = c1Text.Text;*/
            Reload(SAVE_PROGRESS.SingleList);
        }

        private void saveTotal() //保存整个dt，写回excel
        {
            saveNowContent();
            XLSXHelper.DataTableToXlsx(dt, filename, department, departmentName);
        }

        private void singlePrevButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if(singleList.SelectedIndices[0] == 0)
            {
                if (singleList.SelectedIndices[0] == singleList.Items.Count - 1)
                {
                    if(MsgBox.ShowAsk("已经是第一个项了，是否要回到上一条简报？"))
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
                MsgBox.ShowError("保存失败: " + ex.Message);
            }
            this.Close();
            return;
        }

        private void singleNextButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if (singleList.SelectedIndices[0] == singleList.Items.Count - 1)
            {
                if(MsgBox.ShowAsk("已经是最后一个项了，是否要进入下一条简报？"))
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
            if(totalList.Items.Count <= 1)
            {
                MsgBox.ShowError("仅有一条简报，无法删除!");
                return;
            }
            if(MsgBox.ShowAsk("确认要删除本条记录吗？"))
            {
                dt.Rows[totalList.SelectedIndex].Delete();
                MsgBox.ShowInfo("删除成功!");
                Reload(SAVE_PROGRESS.Combo);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if(totalList.SelectedIndex == 0)
            {
                MsgBox.ShowError("已经是第一个简报了。");
                return;
            }
            totalList.SelectedIndex -= 1;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            saveNowContent();
            if (totalList.SelectedIndex == totalList.Items.Count - 1)
            {
                MsgBox.ShowError("已经是最后一个简报了。");
                return;
            }
            totalList.SelectedIndex += 1;
        }

        private void singleContentText_TextChanged(object sender, EventArgs e)
        {
            List<string> keyword = new List<string>() { "／", "－", "(", ")", ".", "	", " " };
            foreach (var word in keyword)
            {

                int s_start = singleContentText.SelectionStart, startIndex = 0, index;

                while ((index = singleContentText.Text.IndexOf(word, startIndex)) != -1)
                {
                    startIndex = index + word.Length;
                    if (index == 0) continue;
                    singleContentText.Select(index, word.Length);
                    singleContentText.SelectionBackColor = Color.Yellow;
                }

                singleContentText.SelectionStart = s_start;
                singleContentText.SelectionLength = 0;
                singleContentText.SelectionBackColor = Color.White;
            }
        }

        public processForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
    }
}
