using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_newnew
{
    //singular cart item, with a name and button that calls cart manager to remove it from collection
    public partial class CartItem : UserControl
    {
        //cart here, each cart item belongs to a cart list (FROM MAIN)
        CartManager cartManager;
        private string dishName;
        private double dishPrice;
        private Item originalItem;
        private int quantity;

        public CartItem(Item item, CartManager cart, int quantity)
        {
            InitializeComponent();
            cartManager = cart;
            dishName = item.GetDishNameOnly();
            dishPrice = item.GetDishPrice();
            originalItem = item;
            this.quantity = quantity;
            CartItemNamePrice.Text = $"{dishName} - x: {quantity.ToString()} - Price: {dishPrice*quantity} $";
        }

        public Item getOriginalItem()
        {
            return originalItem;
        }
        public string GetDishName()
        {
            return dishName;
        }
        public double GetDishPrice()
        {
            return dishPrice;
        }

        //request manager to remove this item
        private void CartItemDeleteButton_Click(object sender, EventArgs e)
        {
            cartManager.RemoveItem(dishName, this);
        }
    }
}
