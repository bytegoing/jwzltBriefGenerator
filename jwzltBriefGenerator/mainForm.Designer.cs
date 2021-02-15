
namespace jwzltBriefGenerator
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.userExportBriefDataButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userProcessToText = new System.Windows.Forms.TextBox();
            this.userProcessFromText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userDepartmentCombo = new System.Windows.Forms.ComboBox();
            this.userChooseFileButton = new System.Windows.Forms.Button();
            this.userFilename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userExportBriefDocButton = new System.Windows.Forms.Button();
            this.userProcessBriefButton = new System.Windows.Forms.Button();
            this.managerTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.userTab.SuspendLayout();
            this.managerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userTab);
            this.tabControl1.Controls.Add(this.managerTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.userExportBriefDataButton);
            this.userTab.Controls.Add(this.username);
            this.userTab.Controls.Add(this.label1);
            this.userTab.Controls.Add(this.userProcessBriefButton);
            this.userTab.Controls.Add(this.label3);
            this.userTab.Controls.Add(this.userExportBriefDocButton);
            this.userTab.Controls.Add(this.label2);
            this.userTab.Controls.Add(this.label7);
            this.userTab.Controls.Add(this.label12);
            this.userTab.Controls.Add(this.userFilename);
            this.userTab.Controls.Add(this.label11);
            this.userTab.Controls.Add(this.userChooseFileButton);
            this.userTab.Controls.Add(this.label10);
            this.userTab.Controls.Add(this.userDepartmentCombo);
            this.userTab.Controls.Add(this.label9);
            this.userTab.Controls.Add(this.label8);
            this.userTab.Controls.Add(this.userProcessToText);
            this.userTab.Controls.Add(this.userProcessFromText);
            this.userTab.Location = new System.Drawing.Point(4, 25);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(742, 369);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "用户功能";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // userExportBriefDataButton
            // 
            this.userExportBriefDataButton.Location = new System.Drawing.Point(371, 143);
            this.userExportBriefDataButton.Name = "userExportBriefDataButton";
            this.userExportBriefDataButton.Size = new System.Drawing.Size(168, 38);
            this.userExportBriefDataButton.TabIndex = 11;
            this.userExportBriefDataButton.Text = "6.导出简报数据文件";
            this.userExportBriefDataButton.UseVisualStyleBackColor = true;
            this.userExportBriefDataButton.Click += new System.EventHandler(this.userExportBriefDataButton_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(121, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 25);
            this.username.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "1.汇报者姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "不填默认最后一条";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "不填默认第1条";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "处理范围：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "条";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "条到第";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "从第";
            // 
            // userProcessToText
            // 
            this.userProcessToText.Location = new System.Drawing.Point(592, 91);
            this.userProcessToText.Name = "userProcessToText";
            this.userProcessToText.Size = new System.Drawing.Size(53, 25);
            this.userProcessToText.TabIndex = 12;
            // 
            // userProcessFromText
            // 
            this.userProcessFromText.Location = new System.Drawing.Point(476, 91);
            this.userProcessFromText.Name = "userProcessFromText";
            this.userProcessFromText.Size = new System.Drawing.Size(53, 25);
            this.userProcessFromText.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "3.选择院系";
            // 
            // userDepartmentCombo
            // 
            this.userDepartmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDepartmentCombo.FormattingEnabled = true;
            this.userDepartmentCombo.Location = new System.Drawing.Point(106, 91);
            this.userDepartmentCombo.Name = "userDepartmentCombo";
            this.userDepartmentCombo.Size = new System.Drawing.Size(209, 23);
            this.userDepartmentCombo.TabIndex = 9;
            // 
            // userChooseFileButton
            // 
            this.userChooseFileButton.Location = new System.Drawing.Point(684, 48);
            this.userChooseFileButton.Name = "userChooseFileButton";
            this.userChooseFileButton.Size = new System.Drawing.Size(45, 26);
            this.userChooseFileButton.TabIndex = 8;
            this.userChooseFileButton.Text = "选择";
            this.userChooseFileButton.UseVisualStyleBackColor = true;
            this.userChooseFileButton.Click += new System.EventHandler(this.userChooseFileButton_Click);
            // 
            // userFilename
            // 
            this.userFilename.Location = new System.Drawing.Point(175, 49);
            this.userFilename.Name = "userFilename";
            this.userFilename.ReadOnly = true;
            this.userFilename.Size = new System.Drawing.Size(504, 25);
            this.userFilename.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "2.选择简报数据文件：";
            // 
            // userExportBriefDocButton
            // 
            this.userExportBriefDocButton.Location = new System.Drawing.Point(183, 143);
            this.userExportBriefDocButton.Name = "userExportBriefDocButton";
            this.userExportBriefDocButton.Size = new System.Drawing.Size(168, 38);
            this.userExportBriefDocButton.TabIndex = 6;
            this.userExportBriefDocButton.Text = "5.据模板导出简报文档文件";
            this.userExportBriefDocButton.UseVisualStyleBackColor = true;
            this.userExportBriefDocButton.Click += new System.EventHandler(this.userExportBriefDocButton_Click);
            // 
            // userProcessBriefButton
            // 
            this.userProcessBriefButton.Location = new System.Drawing.Point(20, 143);
            this.userProcessBriefButton.Name = "userProcessBriefButton";
            this.userProcessBriefButton.Size = new System.Drawing.Size(144, 38);
            this.userProcessBriefButton.TabIndex = 5;
            this.userProcessBriefButton.Text = "4.简报数据处理";
            this.userProcessBriefButton.UseVisualStyleBackColor = true;
            this.userProcessBriefButton.Click += new System.EventHandler(this.userProcessBriefButton_Click);
            // 
            // managerTab
            // 
            this.managerTab.Controls.Add(this.button1);
            this.managerTab.Controls.Add(this.button12);
            this.managerTab.Controls.Add(this.button11);
            this.managerTab.Controls.Add(this.button10);
            this.managerTab.Controls.Add(this.button9);
            this.managerTab.Controls.Add(this.button8);
            this.managerTab.Controls.Add(this.label5);
            this.managerTab.Controls.Add(this.label4);
            this.managerTab.Location = new System.Drawing.Point(4, 25);
            this.managerTab.Name = "managerTab";
            this.managerTab.Padding = new System.Windows.Forms.Padding(3);
            this.managerTab.Size = new System.Drawing.Size(742, 369);
            this.managerTab.TabIndex = 1;
            this.managerTab.Text = "管理功能";
            this.managerTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "合并简报数据";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(403, 147);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(99, 38);
            this.button12.TabIndex = 17;
            this.button12.Text = "3.导出评分表";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(298, 147);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 38);
            this.button11.TabIndex = 16;
            this.button11.Text = "2.评分";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(193, 147);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 38);
            this.button10.TabIndex = 15;
            this.button10.Text = "1.导入待评分简报数据";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(298, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 38);
            this.button9.TabIndex = 14;
            this.button9.Text = "2.导出简报数据";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(193, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 38);
            this.button8.TabIndex = 13;
            this.button8.Text = "1.原始数据导入";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "B.简报评分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "A.简报原始数据处理";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "NEPU教务助理团简报助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.managerTab.ResumeLayout(false);
            this.managerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.TabPage managerTab;
        private System.Windows.Forms.Button userProcessBriefButton;
        private System.Windows.Forms.Button userExportBriefDocButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button userChooseFileButton;
        private System.Windows.Forms.TextBox userFilename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userDepartmentCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userProcessToText;
        private System.Windows.Forms.TextBox userProcessFromText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button userExportBriefDataButton;
    }
}

