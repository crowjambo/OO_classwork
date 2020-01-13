namespace Task5RestoHelper.Forms
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
            this.loginBTN = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
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
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(80, 297);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(123, 39);
            this.loginBTN.TabIndex = 1;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Location = new System.Drawing.Point(218, 297);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(123, 39);
            this.RegisterBTN.TabIndex = 2;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(80, 110);
            this.nicknameTextBox.MaxLength = 20;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(261, 20);
            this.nicknameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nickname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(83, 166);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(261, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.loginBTN);
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
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}