namespace Task6Practice.Forms
{
    partial class IntroScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdminControlBtn = new System.Windows.Forms.Button();
            this.OrderManageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resto-Helper";
            // 
            // AdminControlBtn
            // 
            this.AdminControlBtn.Location = new System.Drawing.Point(12, 98);
            this.AdminControlBtn.Name = "AdminControlBtn";
            this.AdminControlBtn.Size = new System.Drawing.Size(147, 23);
            this.AdminControlBtn.TabIndex = 1;
            this.AdminControlBtn.Text = "Admin Control";
            this.AdminControlBtn.UseVisualStyleBackColor = true;
            this.AdminControlBtn.Click += new System.EventHandler(this.AdminControlBtn_Click);
            // 
            // OrderManageBtn
            // 
            this.OrderManageBtn.Location = new System.Drawing.Point(219, 98);
            this.OrderManageBtn.Name = "OrderManageBtn";
            this.OrderManageBtn.Size = new System.Drawing.Size(147, 23);
            this.OrderManageBtn.TabIndex = 2;
            this.OrderManageBtn.Text = "Order Management";
            this.OrderManageBtn.UseVisualStyleBackColor = true;
            this.OrderManageBtn.Click += new System.EventHandler(this.OrderManageBtn_Click);
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 167);
            this.Controls.Add(this.OrderManageBtn);
            this.Controls.Add(this.AdminControlBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroScreen";
            this.Text = "IntroScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminControlBtn;
        private System.Windows.Forms.Button OrderManageBtn;
    }
}