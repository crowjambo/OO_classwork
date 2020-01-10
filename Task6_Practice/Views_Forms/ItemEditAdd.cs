using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task6Practice.Controllers;
using Task6Practice;

namespace Task6Practice.Forms
{
    public partial class ItemEditAdd : Form
    {
        private int id;
        private AdminController controller;

        public ItemEditAdd(int id, AdminController controller)
        {
            InitializeComponent();
            this.id = id;
            this.controller = controller;
        }

        // on load init and fill out all of fields for Dish Item for DB with ID of sent through item
        private void ItemEditAdd_Load(object sender, EventArgs e)
        {
            // if id not -1
            if(this.id > -1)
            {
                // load using controller data access from dishes where ID = passed ID
                Dish temp = controller.DatabaseLookUp(this.id);

                // using that var set all of input boxes values text to that
                NameBox.Text = temp.DishName;
                DescriptionBox.Text = temp.DishDescription;
                PicUrlBox.Text = temp.Picture;
                PriceTextBox.Text = temp.Price.ToString(); //double
                CategoryBox.Text = temp.Category.ToString(); //int
            }


        }



        // submit button, that checks for correct inputs/data types and then using controller submits that data to DB
        private void SubmitBTN_Click(object sender, EventArgs e)
        {

            // check for errors
            InputCheck();

            //pass into controller + collect the ID too, if ID -1, you know to create new one in controller!! (instead of update)
            controller.UpdateDatabase(this.id, NameBox.Text, DescriptionBox.Text, PicUrlBox.Text, Double.Parse(PriceTextBox.Text) , int.Parse(CategoryBox.Text));

            MessageBox.Show("Success");
        }


        // check whether inputted info is well formatted, isnt empty etc
        private void InputCheck()
        {
            // if statements, check, correct, warn with messageboxes etc etc
        }
 
    }
}
