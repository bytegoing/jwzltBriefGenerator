
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
            this.mergeButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.formatDataButton = new System.Windows.Forms.Button();
            this.editOriginDataButton = new System.Windows.Forms.Button();
            this.exportOriginData = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.originDataFileText = new System.Windows.Forms.TextBox();
            this.originDataFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupDataFileText = new System.Windows.Forms.TextBox();
            this.groupDataFileButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trimCheck = new System.Windows.Forms.CheckBox();
            this.removeLetterCheck = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // userExportBriefDataButton
            // 
            this.userExportBriefDataButton.Location = new System.Drawing.Point(341, 154);
            this.userExportBriefDataButton.Name = "userExportBriefDataButton";
            this.userExportBriefDataButton.Size = new System.Drawing.Size(168, 38);
            this.userExportBriefDataButton.TabIndex = 11;
            this.userExportBriefDataButton.Text = "6.导出简报数据文件";
            this.userExportBriefDataButton.UseVisualStyleBackColor = true;
            this.userExportBriefDataButton.Click += new System.EventHandler(this.userExportBriefDataButton_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(110, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 25);
            this.username.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "1.操作者姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "不填默认最后一条";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "不填默认第1条";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "处理范围：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(641, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "条";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "条到第";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "从第";
            // 
            // userProcessToText
            // 
            this.userProcessToText.Location = new System.Drawing.Point(582, 99);
            this.userProcessToText.Name = "userProcessToText";
            this.userProcessToText.Size = new System.Drawing.Size(53, 25);
            this.userProcessToText.TabIndex = 12;
            // 
            // userProcessFromText
            // 
            this.userProcessFromText.Location = new System.Drawing.Point(466, 99);
            this.userProcessFromText.Name = "userProcessFromText";
            this.userProcessFromText.Size = new System.Drawing.Size(53, 25);
            this.userProcessFromText.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "3.选择院系";
            // 
            // userDepartmentCombo
            // 
            this.userDepartmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDepartmentCombo.FormattingEnabled = true;
            this.userDepartmentCombo.Location = new System.Drawing.Point(96, 99);
            this.userDepartmentCombo.Name = "userDepartmentCombo";
            this.userDepartmentCombo.Size = new System.Drawing.Size(209, 23);
            this.userDepartmentCombo.TabIndex = 9;
            // 
            // userChooseFileButton
            // 
            this.userChooseFileButton.Location = new System.Drawing.Point(673, 57);
            this.userChooseFileButton.Name = "userChooseFileButton";
            this.userChooseFileButton.Size = new System.Drawing.Size(45, 26);
            this.userChooseFileButton.TabIndex = 8;
            this.userChooseFileButton.Text = "选择";
            this.userChooseFileButton.UseVisualStyleBackColor = true;
            this.userChooseFileButton.Click += new System.EventHandler(this.userChooseFileButton_Click);
            // 
            // userFilename
            // 
            this.userFilename.Location = new System.Drawing.Point(185, 58);
            this.userFilename.Name = "userFilename";
            this.userFilename.ReadOnly = true;
            this.userFilename.Size = new System.Drawing.Size(483, 25);
            this.userFilename.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "2.院简报数据文件(xlsx)";
            // 
            // userExportBriefDocButton
            // 
            this.userExportBriefDocButton.Location = new System.Drawing.Point(164, 154);
            this.userExportBriefDocButton.Name = "userExportBriefDocButton";
            this.userExportBriefDocButton.Size = new System.Drawing.Size(168, 38);
            this.userExportBriefDocButton.TabIndex = 6;
            this.userExportBriefDocButton.Text = "5.据模板导出简报文档文件";
            this.userExportBriefDocButton.UseVisualStyleBackColor = true;
            this.userExportBriefDocButton.Click += new System.EventHandler(this.userExportBriefDocButton_Click);
            // 
            // userProcessBriefButton
            // 
            this.userProcessBriefButton.Location = new System.Drawing.Point(9, 154);
            this.userProcessBriefButton.Name = "userProcessBriefButton";
            this.userProcessBriefButton.Size = new System.Drawing.Size(144, 38);
            this.userProcessBriefButton.TabIndex = 5;
            this.userProcessBriefButton.Text = "4.简报数据处理";
            this.userProcessBriefButton.UseVisualStyleBackColor = true;
            this.userProcessBriefButton.Click += new System.EventHandler(this.userProcessBriefButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(6, 24);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(203, 38);
            this.mergeButton.TabIndex = 18;
            this.mergeButton.Text = "合并多份简报数据文件";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(253, 55);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(99, 38);
            this.scoreButton.TabIndex = 15;
            this.scoreButton.Text = "1.进入评分";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // formatDataButton
            // 
            this.formatDataButton.Location = new System.Drawing.Point(272, 19);
            this.formatDataButton.Name = "formatDataButton";
            this.formatDataButton.Size = new System.Drawing.Size(99, 38);
            this.formatDataButton.TabIndex = 14;
            this.formatDataButton.Text = "2.格式化";
            this.formatDataButton.UseVisualStyleBackColor = true;
            this.formatDataButton.Click += new System.EventHandler(this.formatDataButton_Click);
            // 
            // editOriginDataButton
            // 
            this.editOriginDataButton.Location = new System.Drawing.Point(11, 74);
            this.editOriginDataButton.Name = "editOriginDataButton";
            this.editOriginDataButton.Size = new System.Drawing.Size(99, 38);
            this.editOriginDataButton.TabIndex = 13;
            this.editOriginDataButton.Text = "1.原始数据裁剪";
            this.editOriginDataButton.UseVisualStyleBackColor = true;
            this.editOriginDataButton.Click += new System.EventHandler(this.editOriginDataButton_Click);
            // 
            // exportOriginData
            // 
            this.exportOriginData.Location = new System.Drawing.Point(528, 74);
            this.exportOriginData.Name = "exportOriginData";
            this.exportOriginData.Size = new System.Drawing.Size(99, 38);
            this.exportOriginData.TabIndex = 20;
            this.exportOriginData.Text = "3.导出为简报数据文件";
            this.exportOriginData.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(670, 47);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(61, 27);
            this.aboutButton.TabIndex = 21;
            this.aboutButton.Text = "关于";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userExportBriefDataButton);
            this.groupBox1.Controls.Add(this.userExportBriefDocButton);
            this.groupBox1.Controls.Add(this.userProcessBriefButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.userFilename);
            this.groupBox1.Controls.Add(this.userProcessFromText);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.userChooseFileButton);
            this.groupBox1.Controls.Add(this.userProcessToText);
            this.groupBox1.Controls.Add(this.userDepartmentCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 206);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A.简报文件生成";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.originDataFileText);
            this.groupBox2.Controls.Add(this.originDataFileButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.exportOriginData);
            this.groupBox2.Controls.Add(this.editOriginDataButton);
            this.groupBox2.Location = new System.Drawing.Point(7, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 145);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B.简报原始数据处理";
            // 
            // originDataFileText
            // 
            this.originDataFileText.Location = new System.Drawing.Point(197, 24);
            this.originDataFileText.Name = "originDataFileText";
            this.originDataFileText.ReadOnly = true;
            this.originDataFileText.Size = new System.Drawing.Size(473, 25);
            this.originDataFileText.TabIndex = 23;
            // 
            // originDataFileButton
            // 
            this.originDataFileButton.Location = new System.Drawing.Point(675, 23);
            this.originDataFileButton.Name = "originDataFileButton";
            this.originDataFileButton.Size = new System.Drawing.Size(45, 26);
            this.originDataFileButton.TabIndex = 22;
            this.originDataFileButton.Text = "选择";
            this.originDataFileButton.UseVisualStyleBackColor = true;
            this.originDataFileButton.Click += new System.EventHandler(this.originDataFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "1.原始简报数据文件(csv)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupCombo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupDataFileText);
            this.groupBox3.Controls.Add(this.groupDataFileButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.scoreButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 99);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "C.简报评分";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mergeButton);
            this.groupBox4.Controls.Add(this.aboutButton);
            this.groupBox4.Location = new System.Drawing.Point(7, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 83);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "D.其他操作";
            // 
            // groupDataFileText
            // 
            this.groupDataFileText.Location = new System.Drawing.Point(197, 23);
            this.groupDataFileText.Name = "groupDataFileText";
            this.groupDataFileText.ReadOnly = true;
            this.groupDataFileText.Size = new System.Drawing.Size(476, 25);
            this.groupDataFileText.TabIndex = 26;
            // 
            // groupDataFileButton
            // 
            this.groupDataFileButton.Location = new System.Drawing.Point(679, 23);
            this.groupDataFileButton.Name = "groupDataFileButton";
            this.groupDataFileButton.Size = new System.Drawing.Size(45, 26);
            this.groupDataFileButton.TabIndex = 25;
            this.groupDataFileButton.Text = "选择";
            this.groupDataFileButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "1.部简报数据文件(xlsx)";
            // 
            // groupCombo
            // 
            this.groupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCombo.FormattingEnabled = true;
            this.groupCombo.Location = new System.Drawing.Point(101, 61);
            this.groupCombo.Name = "groupCombo";
            this.groupCombo.Size = new System.Drawing.Size(130, 23);
            this.groupCombo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "2.选择部门";
            // 
            // trimCheck
            // 
            this.trimCheck.AutoSize = true;
            this.trimCheck.Checked = true;
            this.trimCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trimCheck.Location = new System.Drawing.Point(6, 49);
            this.trimCheck.Name = "trimCheck";
            this.trimCheck.Size = new System.Drawing.Size(179, 19);
            this.trimCheck.TabIndex = 24;
            this.trimCheck.Text = "去除文本两端空白字符";
            this.trimCheck.UseVisualStyleBackColor = true;
            // 
            // removeLetterCheck
            // 
            this.removeLetterCheck.AutoSize = true;
            this.removeLetterCheck.Checked = true;
            this.removeLetterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeLetterCheck.Location = new System.Drawing.Point(6, 24);
            this.removeLetterCheck.Name = "removeLetterCheck";
            this.removeLetterCheck.Size = new System.Drawing.Size(256, 19);
            this.removeLetterCheck.TabIndex = 25;
            this.removeLetterCheck.Text = "去除字母标号(例：A.必修→必修)";
            this.removeLetterCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.removeLetterCheck);
            this.groupBox5.Controls.Add(this.trimCheck);
            this.groupBox5.Controls.Add(this.formatDataButton);
            this.groupBox5.Location = new System.Drawing.Point(121, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 76);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "2.格式化";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 577);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "NEPU教务助理团简报助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button userProcessBriefButton;
        private System.Windows.Forms.Button userExportBriefDocButton;
        private System.Windows.Forms.Button formatDataButton;
        private System.Windows.Forms.Button editOriginDataButton;
        private System.Windows.Forms.Button scoreButton;
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
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button userExportBriefDataButton;
        private System.Windows.Forms.Button exportOriginData;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox originDataFileText;
        private System.Windows.Forms.Button originDataFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox groupCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox groupDataFileText;
        private System.Windows.Forms.Button groupDataFileButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox removeLetterCheck;
        private System.Windows.Forms.CheckBox trimCheck;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

