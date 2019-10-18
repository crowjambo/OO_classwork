namespace Task3
{
    partial class GroupInfoForm
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
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.SubjectsList = new System.Windows.Forms.ListBox();
            this.GradesList = new System.Windows.Forms.ListBox();
            this.AddGradeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Top3StudentsList = new System.Windows.Forms.ListBox();
            this.DeleteGradeBtn = new System.Windows.Forms.Button();
            this.GradeInputBox = new System.Windows.Forms.TextBox();
            this.SubjectAverageLabel = new System.Windows.Forms.Label();
            this.OverallAverageLabel = new System.Windows.Forms.Label();
            this.WholeGroupAverageLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(13, 32);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(159, 394);
            this.StudentsList.TabIndex = 0;
            // 
            // SubjectsList
            // 
            this.SubjectsList.FormattingEnabled = true;
            this.SubjectsList.Location = new System.Drawing.Point(178, 32);
            this.SubjectsList.Name = "SubjectsList";
            this.SubjectsList.Size = new System.Drawing.Size(151, 394);
            this.SubjectsList.TabIndex = 1;
            // 
            // GradesList
            // 
            this.GradesList.FormattingEnabled = true;
            this.GradesList.Location = new System.Drawing.Point(335, 32);
            this.GradesList.Name = "GradesList";
            this.GradesList.Size = new System.Drawing.Size(74, 394);
            this.GradesList.TabIndex = 2;
            // 
            // AddGradeBtn
            // 
            this.AddGradeBtn.Location = new System.Drawing.Point(534, 27);
            this.AddGradeBtn.Name = "AddGradeBtn";
            this.AddGradeBtn.Size = new System.Drawing.Size(95, 23);
            this.AddGradeBtn.TabIndex = 3;
            this.AddGradeBtn.Text = "Add Grade";
            this.AddGradeBtn.UseVisualStyleBackColor = true;
            this.AddGradeBtn.Click += new System.EventHandler(this.AddGradeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subjects Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Overall student average:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Whole group average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Top 3 students:";
            // 
            // Top3StudentsList
            // 
            this.Top3StudentsList.FormattingEnabled = true;
            this.Top3StudentsList.Location = new System.Drawing.Point(476, 288);
            this.Top3StudentsList.Name = "Top3StudentsList";
            this.Top3StudentsList.Size = new System.Drawing.Size(209, 95);
            this.Top3StudentsList.TabIndex = 9;
            // 
            // DeleteGradeBtn
            // 
            this.DeleteGradeBtn.Location = new System.Drawing.Point(635, 27);
            this.DeleteGradeBtn.Name = "DeleteGradeBtn";
            this.DeleteGradeBtn.Size = new System.Drawing.Size(95, 23);
            this.DeleteGradeBtn.TabIndex = 10;
            this.DeleteGradeBtn.Text = "Delete Grade";
            this.DeleteGradeBtn.UseVisualStyleBackColor = true;
            this.DeleteGradeBtn.Click += new System.EventHandler(this.DeleteGradeBtn_Click);
            // 
            // GradeInputBox
            // 
            this.GradeInputBox.Location = new System.Drawing.Point(504, 29);
            this.GradeInputBox.Name = "GradeInputBox";
            this.GradeInputBox.Size = new System.Drawing.Size(24, 20);
            this.GradeInputBox.TabIndex = 11;
            // 
            // SubjectAverageLabel
            // 
            this.SubjectAverageLabel.AutoSize = true;
            this.SubjectAverageLabel.Location = new System.Drawing.Point(531, 72);
            this.SubjectAverageLabel.Name = "SubjectAverageLabel";
            this.SubjectAverageLabel.Size = new System.Drawing.Size(25, 13);
            this.SubjectAverageLabel.TabIndex = 12;
            this.SubjectAverageLabel.Text = "Null";
            // 
            // OverallAverageLabel
            // 
            this.OverallAverageLabel.AutoSize = true;
            this.OverallAverageLabel.Location = new System.Drawing.Point(563, 103);
            this.OverallAverageLabel.Name = "OverallAverageLabel";
            this.OverallAverageLabel.Size = new System.Drawing.Size(25, 13);
            this.OverallAverageLabel.TabIndex = 13;
            this.OverallAverageLabel.Text = "Null";
            // 
            // WholeGroupAverageLabel
            // 
            this.WholeGroupAverageLabel.AutoSize = true;
            this.WholeGroupAverageLabel.Location = new System.Drawing.Point(592, 250);
            this.WholeGroupAverageLabel.Name = "WholeGroupAverageLabel";
            this.WholeGroupAverageLabel.Size = new System.Drawing.Size(25, 13);
            this.WholeGroupAverageLabel.TabIndex = 14;
            this.WholeGroupAverageLabel.Text = "Null";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(479, 403);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(206, 23);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back to main";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // GroupInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WholeGroupAverageLabel);
            this.Controls.Add(this.OverallAverageLabel);
            this.Controls.Add(this.SubjectAverageLabel);
            this.Controls.Add(this.GradeInputBox);
            this.Controls.Add(this.DeleteGradeBtn);
            this.Controls.Add(this.Top3StudentsList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddGradeBtn);
            this.Controls.Add(this.GradesList);
            this.Controls.Add(this.SubjectsList);
            this.Controls.Add(this.StudentsList);
            this.Name = "GroupInfoForm";
            this.Text = "GroupInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.ListBox SubjectsList;
        private System.Windows.Forms.ListBox GradesList;
        private System.Windows.Forms.Button AddGradeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Top3StudentsList;
        private System.Windows.Forms.Button DeleteGradeBtn;
        private System.Windows.Forms.TextBox GradeInputBox;
        private System.Windows.Forms.Label SubjectAverageLabel;
        private System.Windows.Forms.Label OverallAverageLabel;
        private System.Windows.Forms.Label WholeGroupAverageLabel;
        private System.Windows.Forms.Button BackBtn;
    }
}