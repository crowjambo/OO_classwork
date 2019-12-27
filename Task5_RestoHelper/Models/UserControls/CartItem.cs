using System;
using System.Windows.Forms;
using Task5RestoHelper.Controllers;

namespace Task5RestoHelper
{
    //singular cart item, with a name and button that calls cart manager to remove it from collection
    public partial class CartItem : UserControl
    {
        //cart here, each cart item belongs to a cart list (FROM MAIN)
        OrderManagementController controller;
        private string dishName;
        private double dishPrice;
        private Item originalItem;
        private int quantity;

        public CartItem(Item item, OrderManagementController controller, int quantity)
        {
            InitializeComponent();
            this.controller = controller;
            dishName = item.GetDishNameOnly();
            dishPrice = item.GetDishPrice();
            originalItem = item;
            this.quantity = quantity;
            CartItemNamePrice.Text = $"{dishName} - x: {quantity.ToString()} - Price: {dishPrice*quantity} $";
        }

        public Item GetOriginalItem()
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
            controller.GetCart().RemoveItem(dishName);
            controller.UpdateCart();
        }
    }
}
