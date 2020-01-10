namespace Task6Practice.UserControls
{
    partial class ItemAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditBtn = new System.Windows.Forms.Button();
            this.ItemInfoLabel = new System.Windows.Forms.Label();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(672, 32);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ItemInfoLabel
            // 
            this.ItemInfoLabel.Location = new System.Drawing.Point(3, 9);
            this.ItemInfoLabel.MaximumSize = new System.Drawing.Size(663, 49);
            this.ItemInfoLabel.Name = "ItemInfoLabel";
            this.ItemInfoLabel.Size = new System.Drawing.Size(663, 49);
            this.ItemInfoLabel.TabIndex = 2;
            this.ItemInfoLabel.Text = "label1";
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(672, 3);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveBTN.TabIndex = 3;
            this.RemoveBTN.Text = "Remove";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // ItemAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.ItemInfoLabel);
            this.Controls.Add(this.EditBtn);
            this.Name = "ItemAdmin";
            this.Size = new System.Drawing.Size(760, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label ItemInfoLabel;
        private System.Windows.Forms.Button RemoveBTN;
    }
}
