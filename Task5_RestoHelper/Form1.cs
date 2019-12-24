using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5RestoHelper
{
    //performs all of the data pulling and displaying
    public partial class Form1 : Form
    {
        //dishes collection
        List<DishesModel> dishes;
        //cart managing
        CartManager cartManager;

        public Form1()
        {
            InitializeComponent();  
        }

        private void LoadDishes()
        {
            //get dishes list from db
            dishes = SqliteDataAccess.LoadDishes();
      
            //using list (REAL)
            int yDiff = 262;
            int xDiff = 332;
            int counter = 0;
            int colCounter = 0;
            foreach (var dish in dishes)
            {
                Item newItem = new Item(dish.DishName, dish.Picture, dish.Price, dish.DishDescription, cartManager);

                if (counter % 2 == 0)
                {
                    newItem.Location = new Point(10, 15 + (colCounter * yDiff));
                }
                else
                {
                    newItem.Location = new Point(10 + xDiff, 15 + (colCounter * yDiff));
                    colCounter++;
                }
                counter++;
                panel1.Controls.Add(newItem);
            }
        }
        public void RefreshCart(Dictionary<string, List<CartItem>> cart)
        {
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

            //create new CartItem objects placed in proper places based on KEYS
            List<CartItem> temp;
            int positionIncrementer = 120;
            foreach(var item in cart)
            {
                //for each key, create 1 item, but depending on that keys CartList count, append diff Quantity number
                cart.TryGetValue(item.Key, out temp);
                CartItem newItem = new CartItem(temp[0].GetOriginalItem(), cartManager, temp.Count);
                CartPanel.Controls.Add(newItem);
                newItem.Location = new Point(16, positionIncrementer);

                //next position will be lower
                positionIncrementer += 40;
            }

            //at the very end append label for showing total currentCost
            Label totalCountLabel = new Label
            {
                Location = new Point(126, positionIncrementer),
                Text = $"Current Total: {cartManager.GetTotalWithoutVAT().ToString()} $",

            };
            totalCountLabel.Font = new Font("Arial", 12);
            totalCountLabel.AutoSize = true;
            totalCountLabel.TabIndex = 1;
            //next position will be lower
            positionIncrementer += 40;
            CartPanel.Controls.Add(totalCountLabel);

            //at the very bottom add checkout btn
            Button checkoutBtn = new Button();
            checkoutBtn.Size = new Size(75, 23);
            checkoutBtn.Text = "Checkout";
            checkoutBtn.Click += new System.EventHandler(this.CheckoutButton_Click);
            checkoutBtn.Location = new Point(100, positionIncrementer);
            CartPanel.Controls.Add(checkoutBtn);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init cart manager
            cartManager = new CartManager(this);
            //initialises dishes from database and creates display
            LoadDishes();

        }

        //final check out processing
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutForm newForm = new CheckoutForm(cartManager);
            newForm.Show();
        }

        
    }
}
