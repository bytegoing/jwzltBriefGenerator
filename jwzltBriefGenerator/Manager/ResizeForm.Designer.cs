
namespace jwzltBriefGenerator.Manager
{
    partial class ResizeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.filterColumnCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.columnList = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.userProcessFromText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userProcessToText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "1.请选中需要保留的列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "按Ctrl同时点击项目进行多选";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "2.关键字过滤(留空不过滤)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(283, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "完成配置并保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // filterColumnCombo
            // 
            this.filterColumnCombo.FormattingEnabled = true;
            this.filterColumnCombo.Location = new System.Drawing.Point(296, 47);
            this.filterColumnCombo.Name = "filterColumnCombo";
            this.filterColumnCombo.Size = new System.Drawing.Size(160, 23);
            this.filterColumnCombo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "列名称";
            // 
            // filterText
            // 
            this.filterText.Location = new System.Drawing.Point(296, 76);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(160, 25);
            this.filterText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "等于";
            // 
            // columnList
            // 
            this.columnList.HideSelection = false;
            this.columnList.Location = new System.Drawing.Point(15, 69);
            this.columnList.Name = "columnList";
            this.columnList.Size = new System.Drawing.Size(212, 408);
            this.columnList.TabIndex = 11;
            this.columnList.UseCompatibleStateImageBehavior = false;
            this.columnList.View = System.Windows.Forms.View.Details;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "条";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "3.保留简报条数范围：";
            // 
            // userProcessFromText
            // 
            this.userProcessFromText.Location = new System.Drawing.Point(259, 133);
            this.userProcessFromText.Name = "userProcessFromText";
            this.userProcessFromText.Size = new System.Drawing.Size(53, 25);
            this.userProcessFromText.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "条到第";
            // 
            // userProcessToText
            // 
            this.userProcessToText.Location = new System.Drawing.Point(375, 133);
            this.userProcessToText.Name = "userProcessToText";
            this.userProcessToText.Size = new System.Drawing.Size(53, 25);
            this.userProcessToText.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "不填默认最后一条";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "不填默认第1条";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "第";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "文件：";
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(70, 9);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(71, 15);
            this.filenameLabel.TabIndex = 27;
            this.filenameLabel.Text = "filename";
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 489);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userProcessFromText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userProcessToText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.columnList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterColumnCombo);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ResizeForm";
            this.Text = "1.原始简报数据裁剪 - A.简报原始数据处理";
            this.Load += new System.EventHandler(this.ResizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox filterColumnCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView columnList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userProcessFromText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userProcessToText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filenameLabel;
    }
}