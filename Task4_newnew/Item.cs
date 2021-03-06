﻿using System;
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
    //singular item data model
    public partial class Item : UserControl
    {
        //cart here
        CartManager cartManager;
        //vars to use later
        private string dishName;
        private double dishPrice;

        public Item(string productName, string pictureURL, double price, string description, CartManager cart)
        {
            InitializeComponent();
            ProductName.Text = productName;
            Picture.ImageLocation = pictureURL;
            PriceLabel.Text = $"Price: + {price.ToString()} $";
            DescriptionLabel.Text = description;
            this.cartManager = cart;
            dishName = productName;
            dishPrice = price;
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
            //send it through to our global/shared manager
            cartManager.CreateNewItem(this);
        }


    }
}
