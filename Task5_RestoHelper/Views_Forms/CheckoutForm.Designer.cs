namespace Task5RestoHelper
{
    partial class CheckoutForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalNoVatLabel = new System.Windows.Forms.Label();
            this.TotalWithVatLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveReceiptBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.SaveReceiptBtn);
            this.panel1.Controls.Add(this.TotalNoVatLabel);
            this.panel1.Controls.Add(this.TotalWithVatLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrderDateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 345);
            this.panel1.TabIndex = 1;
            // 
            // TotalNoVatLabel
            // 
            this.TotalNoVatLabel.AutoSize = true;
            this.TotalNoVatLabel.Location = new System.Drawing.Point(59, 236);
            this.TotalNoVatLabel.Name = "TotalNoVatLabel";
            this.TotalNoVatLabel.Size = new System.Drawing.Size(110, 13);
            this.TotalNoVatLabel.TabIndex = 6;
            this.TotalNoVatLabel.Text = "Total without VAT = $";
            // 
            // TotalWithVatLabel
            // 
            this.TotalWithVatLabel.AutoSize = true;
            this.TotalWithVatLabel.Location = new System.Drawing.Point(59, 208);
            this.TotalWithVatLabel.Name = "TotalWithVatLabel";
            this.TotalWithVatLabel.Size = new System.Drawing.Size(82, 13);
            this.TotalWithVatLabel.TabIndex = 5;
            this.TotalWithVatLabel.Text = "Total + VAT = $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Items:";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(17, 56);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(113, 13);
            this.OrderDateLabel.TabIndex = 2;
            this.OrderDateLabel.Text = "Order date: new date()";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill";
            // 
            // SaveReceiptBtn
            // 
            this.SaveReceiptBtn.Location = new System.Drawing.Point(131, 301);
            this.SaveReceiptBtn.Name = "SaveReceiptBtn";
            this.SaveReceiptBtn.Size = new System.Drawing.Size(104, 23);
            this.SaveReceiptBtn.TabIndex = 7;
            this.SaveReceiptBtn.Text = "Save Receipt";
            this.SaveReceiptBtn.UseVisualStyleBackColor = true;
            this.SaveReceiptBtn.Click += new System.EventHandler(this.SaveReceiptBtn_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 370);
            this.Controls.Add(this.panel1);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalNoVatLabel;
        private System.Windows.Forms.Label TotalWithVatLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveReceiptBtn;
    }
}