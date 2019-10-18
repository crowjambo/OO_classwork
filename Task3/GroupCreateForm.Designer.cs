namespace Task3
{
    partial class GroupCreateForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SemesterNumberTextBox = new System.Windows.Forms.TextBox();
            this.GroupTitle = new System.Windows.Forms.Label();
            this.SemesterNumber = new System.Windows.Forms.Label();
            this.AddSubjectBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.SaveGroupBtn = new System.Windows.Forms.Button();
            this.CancelGroupBtn = new System.Windows.Forms.Button();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.SubjectsListBox = new System.Windows.Forms.ListBox();
            this.RemoveSubjectBtn = new System.Windows.Forms.Button();
            this.RemoveStudentBtn = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(106, 28);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // SemesterNumberTextBox
            // 
            this.SemesterNumberTextBox.Location = new System.Drawing.Point(106, 73);
            this.SemesterNumberTextBox.Name = "SemesterNumberTextBox";
            this.SemesterNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.SemesterNumberTextBox.TabIndex = 1;
            // 
            // GroupTitle
            // 
            this.GroupTitle.AutoSize = true;
            this.GroupTitle.Location = new System.Drawing.Point(73, 31);
            this.GroupTitle.Name = "GroupTitle";
            this.GroupTitle.Size = new System.Drawing.Size(27, 13);
            this.GroupTitle.TabIndex = 2;
            this.GroupTitle.Text = "Title";
            // 
            // SemesterNumber
            // 
            this.SemesterNumber.AutoSize = true;
            this.SemesterNumber.Location = new System.Drawing.Point(12, 76);
            this.SemesterNumber.Name = "SemesterNumber";
            this.SemesterNumber.Size = new System.Drawing.Size(88, 13);
            this.SemesterNumber.TabIndex = 3;
            this.SemesterNumber.Text = "SemesterNumber";
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.Location = new System.Drawing.Point(153, 241);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Size = new System.Drawing.Size(120, 23);
            this.AddSubjectBtn.TabIndex = 4;
            this.AddSubjectBtn.Text = "Add Subject";
            this.AddSubjectBtn.UseVisualStyleBackColor = true;
            this.AddSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(9, 241);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(120, 23);
            this.AddStudentBtn.TabIndex = 5;
            this.AddStudentBtn.Text = "Add Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // SaveGroupBtn
            // 
            this.SaveGroupBtn.Location = new System.Drawing.Point(51, 373);
            this.SaveGroupBtn.Name = "SaveGroupBtn";
            this.SaveGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveGroupBtn.TabIndex = 6;
            this.SaveGroupBtn.Text = "Finish/Save";
            this.SaveGroupBtn.UseVisualStyleBackColor = true;
            this.SaveGroupBtn.Click += new System.EventHandler(this.SaveGroupBtn_Click);
            // 
            // CancelGroupBtn
            // 
            this.CancelGroupBtn.Location = new System.Drawing.Point(153, 372);
            this.CancelGroupBtn.Name = "CancelGroupBtn";
            this.CancelGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelGroupBtn.TabIndex = 7;
            this.CancelGroupBtn.Text = "Cancel";
            this.CancelGroupBtn.UseVisualStyleBackColor = true;
            this.CancelGroupBtn.Click += new System.EventHandler(this.CancelGroupBtn_Click);
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(9, 140);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(120, 95);
            this.StudentsListBox.TabIndex = 8;
            // 
            // SubjectsListBox
            // 
            this.SubjectsListBox.FormattingEnabled = true;
            this.SubjectsListBox.Location = new System.Drawing.Point(153, 140);
            this.SubjectsListBox.Name = "SubjectsListBox";
            this.SubjectsListBox.Size = new System.Drawing.Size(120, 95);
            this.SubjectsListBox.TabIndex = 9;
            // 
            // RemoveSubjectBtn
            // 
            this.RemoveSubjectBtn.Location = new System.Drawing.Point(153, 271);
            this.RemoveSubjectBtn.Name = "RemoveSubjectBtn";
            this.RemoveSubjectBtn.Size = new System.Drawing.Size(120, 23);
            this.RemoveSubjectBtn.TabIndex = 10;
            this.RemoveSubjectBtn.Text = "Remove Subject";
            this.RemoveSubjectBtn.UseVisualStyleBackColor = true;
            this.RemoveSubjectBtn.Click += new System.EventHandler(this.RemoveSubjectBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.Location = new System.Drawing.Point(9, 270);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(120, 23);
            this.RemoveStudentBtn.TabIndex = 11;
            this.RemoveStudentBtn.Text = "Remove Student";
            this.RemoveStudentBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(219, 326);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 12;
            this.Refresh.Text = "refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // GroupCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 435);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.RemoveStudentBtn);
            this.Controls.Add(this.RemoveSubjectBtn);
            this.Controls.Add(this.SubjectsListBox);
            this.Controls.Add(this.StudentsListBox);
            this.Controls.Add(this.CancelGroupBtn);
            this.Controls.Add(this.SaveGroupBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.AddSubjectBtn);
            this.Controls.Add(this.SemesterNumber);
            this.Controls.Add(this.GroupTitle);
            this.Controls.Add(this.SemesterNumberTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "GroupCreateForm";
            this.Text = "GroupCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox SemesterNumberTextBox;
        private System.Windows.Forms.Label GroupTitle;
        private System.Windows.Forms.Label SemesterNumber;
        private System.Windows.Forms.Button AddSubjectBtn;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button SaveGroupBtn;
        private System.Windows.Forms.Button CancelGroupBtn;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.ListBox SubjectsListBox;
        private System.Windows.Forms.Button RemoveSubjectBtn;
        private System.Windows.Forms.Button RemoveStudentBtn;
        private System.Windows.Forms.Button Refresh;
    }
}