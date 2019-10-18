namespace Task3
{
    partial class Form1
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
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditGroupBtn = new System.Windows.Forms.Button();
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(89, 87);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.addGroupBtn.TabIndex = 0;
            this.addGroupBtn.Text = "add group";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(89, 228);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(181, 228);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditGroupBtn
            // 
            this.EditGroupBtn.Location = new System.Drawing.Point(181, 86);
            this.EditGroupBtn.Name = "EditGroupBtn";
            this.EditGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.EditGroupBtn.TabIndex = 3;
            this.EditGroupBtn.Text = "Edit group";
            this.EditGroupBtn.UseVisualStyleBackColor = true;
            this.EditGroupBtn.Click += new System.EventHandler(this.EditGroupBtn_Click);
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Items.AddRange(new object[] {
            "PI18E",
            "ShitGroup"});
            this.GroupListBox.Location = new System.Drawing.Point(89, 127);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(167, 95);
            this.GroupListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(354, 374);
            this.Controls.Add(this.GroupListBox);
            this.Controls.Add(this.EditGroupBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.addGroupBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditGroupBtn;
        private System.Windows.Forms.ListBox GroupListBox;
    }
}

