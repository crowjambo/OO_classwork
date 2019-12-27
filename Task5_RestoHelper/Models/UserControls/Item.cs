using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper.Controllers;

namespace Task5RestoHelper
{
    //singular item data model
    public partial class Item : UserControl
    {
        private OrderManagementController controller;
        //vars to use later
        private string dishName;
        private double dishPrice;

        public Item(string productName, string pictureURL, double price, string description, OrderManagementController controller)
        {
            InitializeComponent();
            ProductName.Text = productName;
            Picture.ImageLocation = pictureURL;
            PriceLabel.Text = $"Price: + {price.ToString()} $";
            DescriptionLabel.Text = description;
            dishName = productName;
            dishPrice = price;
            this.controller = controller;
        }

        public string GetItemNameAndPrice()
        {
            return $"{ProductName.Text} - {PriceLabel.Text}";
        }
        public double GetDishPrice()
        {
            return dishPrice;
        }
        public string GetDishNameOnly()
        {
            return dishName;
        }




        //request cart manager to append selected item to list
        private void AddButton_Click(object sender, EventArgs e)
        {
            var cart = controller.GetCart();
            //send it through to our global/shared manager
            cart.CreateNewItem(this,controller);
            controller.UpdateCart();
        }


    }
}
