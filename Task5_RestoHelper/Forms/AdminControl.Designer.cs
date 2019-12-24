namespace Task5RestoHelper.Forms
{
    partial class AdminControl
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
            this.CreateNewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewBtn
            // 
            this.CreateNewBtn.Location = new System.Drawing.Point(713, 12);
            this.CreateNewBtn.Name = "CreateNewBtn";
            this.CreateNewBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateNewBtn.TabIndex = 0;
            this.CreateNewBtn.Text = "Create New";
            this.CreateNewBtn.UseVisualStyleBackColor = true;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateNewBtn);
            this.Name = "AdminControl";
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewBtn;
    }
}