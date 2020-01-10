using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Task6Practice.Controllers;

namespace Task6Practice
{
    //performs all of the data pulling and displaying
    public partial class Form1 : Form
    {
 
        //Controller this form belongs to
        OrderManagementController controller;

        public Form1()
        {
            InitializeComponent();
            this.controller = new OrderManagementController(this);
        }

        // Display all of items from DB
        public void UpdateDishes()
        {
            List<Item> items = controller.GetItems();

            int yDiff = 262;
            int xDiff = 332;
            int counter = 0;
            int colCounter = 0;
            foreach (var item in items)
            { 
                if (counter % 2 == 0)
                {
                    item.Location = new Point(10, 15 + (colCounter * yDiff));
                }
                else
                {
                    item.Location = new Point(10 + xDiff, 15 + (colCounter * yDiff));
                    colCounter++;
                }
                counter++;
                panel1.Controls.Add(item);
            }
        }
        public void UpdateCart()
        {
            var cart = controller.GetCart();

            #region Label
            //remove everything from cart panel display
            CartPanel.Controls.Clear();

            //at very top create Cart Label
            Label cartLabel = new Label
            {
                Location = new Point(126, 1),
                Text = "Cart",
                Size = new Size(100,100)

            };
            cartLabel.Font = new Font("Arial", 20);
            CartPanel.Controls.Add(cartLabel);
            #endregion

            //create new CartItem objects placed in proper places based on KEYS
            List<CartItem> temp;
            int positionIncrementer = 120;
            foreach(var item in cart.cartCollection)
            {
                //for each key, create 1 item, but depending on that keys CartList count, append diff Quantity number
                cart.cartCollection.TryGetValue(item.Key, out temp);
                CartItem newItem = new CartItem(temp[0].GetOriginalItem(), controller, temp.Count);
                CartPanel.Controls.Add(newItem);
                newItem.Location = new Point(16, positionIncrementer);

                //next position will be lower
                positionIncrementer += 40;
            }


            #region Total cost Label
            //at the very end append label for showing total currentCost
            Label totalCountLabel = new Label
            {
                Location = new Point(126, positionIncrementer),
                Text = $"Current Total: {cart.GetTotalWithoutVAT().ToString()} $",

            };
            totalCountLabel.Font = new Font("Arial", 12);
            totalCountLabel.AutoSize = true;
            totalCountLabel.TabIndex = 1;
            //next position will be lower
            positionIncrementer += 40;
            CartPanel.Controls.Add(totalCountLabel);
            #endregion

            #region Checkout Button
            //at the very bottom add checkout btn
            Button checkoutBtn = new Button();
            checkoutBtn.Size = new Size(75, 23);
            checkoutBtn.Text = "Checkout";
            checkoutBtn.Click += new System.EventHandler(this.CheckoutButton_Click);
            checkoutBtn.Location = new Point(100, positionIncrementer);
            CartPanel.Controls.Add(checkoutBtn);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialises dishes from database and creates display
            controller.UpdateView();

        }

        //final check out processing
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutForm newForm = new CheckoutForm(controller);
            newForm.Show();
        }

        
    }
}
