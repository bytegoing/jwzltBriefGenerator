
namespace jwzltBriefGenerator.User
{
    partial class processForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.departmentText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.singleList = new System.Windows.Forms.ListView();
            this.totalList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.singleNameText = new System.Windows.Forms.Label();
            this.singlePrevButton = new System.Windows.Forms.Button();
            this.singleNextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c2Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.singleContentText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 12);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(98, 26);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "←保存,上条";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(116, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 26);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "保存,下条→";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // departmentText
            // 
            this.departmentText.AutoSize = true;
            this.departmentText.Location = new System.Drawing.Point(466, 18);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(157, 15);
            this.departmentText.TabIndex = 3;
            this.departmentText.Text = "计算机与信息技术学院";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件范围";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "处理进度";
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(221, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(78, 26);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "删除本条";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // singleList
            // 
            this.singleList.HideSelection = false;
            this.singleList.Location = new System.Drawing.Point(241, 70);
            this.singleList.MultiSelect = false;
            this.singleList.Name = "singleList";
            this.singleList.Size = new System.Drawing.Size(219, 499);
            this.singleList.TabIndex = 13;
            this.singleList.UseCompatibleStateImageBehavior = false;
            this.singleList.View = System.Windows.Forms.View.Details;
            this.singleList.SelectedIndexChanged += new System.EventHandler(this.singleList_SelectedIndexChanged);
            // 
            // totalList
            // 
            this.totalList.FormattingEnabled = true;
            this.totalList.ItemHeight = 15;
            this.totalList.Location = new System.Drawing.Point(12, 99);
            this.totalList.Name = "totalList";
            this.totalList.Size = new System.Drawing.Size(195, 469);
            this.totalList.TabIndex = 14;
            this.totalList.SelectedIndexChanged += new System.EventHandler(this.totalList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "2.本条简报所含项目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "1.简报总览";
            // 
            // filterCombo
            // 
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Location = new System.Drawing.Point(85, 72);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(122, 23);
            this.filterCombo.TabIndex = 17;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "→";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "→";
            // 
            // singleNameText
            // 
            this.singleNameText.AutoSize = true;
            this.singleNameText.Location = new System.Drawing.Point(610, 51);
            this.singleNameText.Name = "singleNameText";
            this.singleNameText.Size = new System.Drawing.Size(67, 15);
            this.singleNameText.TabIndex = 0;
            this.singleNameText.Text = "项目名称";
            // 
            // singlePrevButton
            // 
            this.singlePrevButton.Location = new System.Drawing.Point(495, 72);
            this.singlePrevButton.Name = "singlePrevButton";
            this.singlePrevButton.Size = new System.Drawing.Size(98, 26);
            this.singlePrevButton.TabIndex = 2;
            this.singlePrevButton.Text = "↑保存,上项";
            this.singlePrevButton.UseVisualStyleBackColor = true;
            this.singlePrevButton.Click += new System.EventHandler(this.singlePrevButton_Click);
            // 
            // singleNextButton
            // 
            this.singleNextButton.Location = new System.Drawing.Point(599, 72);
            this.singleNextButton.Name = "singleNextButton";
            this.singleNextButton.Size = new System.Drawing.Size(102, 26);
            this.singleNextButton.TabIndex = 3;
            this.singleNextButton.Text = "保存,下项↓";
            this.singleNextButton.UseVisualStyleBackColor = true;
            this.singleNextButton.Click += new System.EventHandler(this.singleNextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(849, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 26);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "保存并退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "展示项目";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "3.项目内容修改";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(386, 18);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(63, 15);
            this.processLabel.TabIndex = 24;
            this.processLabel.Text = "000/000";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(724, 18);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(63, 15);
            this.fileLabel.TabIndex = 25;
            this.fileLabel.Text = "000~000";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(493, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(459, 168);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "提示：\r\n请妥善处理格式与多余字符!\r\n";
            // 
            // c2Text
            // 
            this.c2Text.Location = new System.Drawing.Point(987, 330);
            this.c2Text.Multiline = true;
            this.c2Text.Name = "c2Text";
            this.c2Text.Size = new System.Drawing.Size(323, 238);
            this.c2Text.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "优秀建议（自定义2）";
            // 
            // c1Text
            // 
            this.c1Text.Location = new System.Drawing.Point(987, 69);
            this.c1Text.Multiline = true;
            this.c1Text.Name = "c1Text";
            this.c1Text.Size = new System.Drawing.Size(323, 238);
            this.c1Text.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(984, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "典型问题（自定义1）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(959, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "→";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(984, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "提示：问题与建议序号务必搭配、对应好！";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(724, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "注意修改高亮字符！";
            // 
            // singleContentText
            // 
            this.singleContentText.Location = new System.Drawing.Point(493, 104);
            this.singleContentText.Name = "singleContentText";
            this.singleContentText.Size = new System.Drawing.Size(458, 290);
            this.singleContentText.TabIndex = 35;
            this.singleContentText.Text = "";
            this.singleContentText.TextChanged += new System.EventHandler(this.singleContentText_TextChanged);
            // 
            // processForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 580);
            this.Controls.Add(this.singleContentText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c1Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c2Text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.singleNextButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.singlePrevButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.singleNameText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filterCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalList);
            this.Controls.Add(this.singleList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "processForm";
            this.Text = "4.简报数据处理 - A.简报文件生成";
            this.Load += new System.EventHandler(this.processForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label departmentText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListView singleList;
        private System.Windows.Forms.ListBox totalList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label singleNameText;
        private System.Windows.Forms.Button singleNextButton;
        private System.Windows.Forms.Button singlePrevButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox c2Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c1Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox singleContentText;
    }
}