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
    public partial class CheckoutForm : Form
    {
        //to access collection
        CartManager cart;

        public CheckoutForm(CartManager cart)
        {
            InitializeComponent();
            this.cart = cart;
            
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            //date
            OrderDateLabel.Text = $"Order date: {DateTime.Now}";
            //load all items  
            List<CartItem> temp;
            int positionIncrementer = 101;
            foreach (var item in cart.cartCollection)
            {
                //for each key, create 1 item, append diff Quantity number +total price of that one item
                cart.cartCollection.TryGetValue(item.Key, out temp);
                Label newLabel = new Label
                {
                    Text = $"{temp[0].GetDishName()} x: {temp.Count.ToString()} Total: {(temp[0].GetDishPrice() * temp.Count).ToString()} $",
                    Location = new Point(56, positionIncrementer),
                    AutoSize = true
                };
                panel1.Controls.Add(newLabel);

                //next position will be lower
                positionIncrementer += 27;
            }
            //just for style
            positionIncrementer += 27;

            //CHANGE THESE LOCATION BASED ON THE LAST POSITION OF LAST ELEMENT FROM ITEMS COLLECTION
            //total with vat
            TotalWithVatLabel.Text = $"Total with VAT = {(cart.GetTotalWithoutVAT() * 0.21 + cart.GetTotalWithoutVAT()).ToString()} $";
            TotalWithVatLabel.Location = new Point(59, positionIncrementer);
            positionIncrementer += 27;
            //total no vat
            TotalNoVatLabel.Text = $"Total without VAT = {cart.GetTotalWithoutVAT().ToString()} $";
            TotalNoVatLabel.Location = new Point(50, positionIncrementer);
        }


    }
}
