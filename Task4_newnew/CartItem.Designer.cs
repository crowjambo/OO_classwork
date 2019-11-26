namespace Task4_newnew
{
    partial class CartItem
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
            this.CartItemDeleteButton = new System.Windows.Forms.Button();
            this.CartItemNamePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CartItemDeleteButton
            // 
            this.CartItemDeleteButton.Location = new System.Drawing.Point(345, 6);
            this.CartItemDeleteButton.Name = "CartItemDeleteButton";
            this.CartItemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CartItemDeleteButton.TabIndex = 5;
            this.CartItemDeleteButton.Text = "X";
            this.CartItemDeleteButton.UseVisualStyleBackColor = true;
            this.CartItemDeleteButton.Click += new System.EventHandler(this.CartItemDeleteButton_Click);
            // 
            // CartItemNamePrice
            // 
            this.CartItemNamePrice.AutoSize = true;
            this.CartItemNamePrice.Location = new System.Drawing.Point(3, 8);
            this.CartItemNamePrice.Name = "CartItemNamePrice";
            this.CartItemNamePrice.Size = new System.Drawing.Size(155, 13);
            this.CartItemNamePrice.TabIndex = 4;
            this.CartItemNamePrice.Text = "ItemName - QUANTITY -  Price";
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartItemDeleteButton);
            this.Controls.Add(this.CartItemNamePrice);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(426, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CartItemDeleteButton;
        private System.Windows.Forms.Label CartItemNamePrice;
    }
}
