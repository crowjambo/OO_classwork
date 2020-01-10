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
using Task6Practice.UserControls;

namespace Task6Practice.Forms
{
    public partial class AdminControl : Form
    {
        //controller
        AdminController controller;

        public AdminControl()
        {
            InitializeComponent();
            this.controller = new AdminController(this);
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            //call controlled to update this view
            controller.UpdateView();

        }


        // Refresh items view
        public void UpdateView()
        {
            //remove previous items
            ItemsPanel.Controls.Clear();

            //using controller items model, list all items
            List<ItemAdmin> items = controller.GetItems();

            int yDiff = 110;
            int colCounter = 0;
    
            foreach (var item in items)
            {
      
                item.Location = new Point(10, 15 + (colCounter * yDiff));
                colCounter++;
               
                ItemsPanel.Controls.Add(item);
            }
        }

        // open a form empty
        private void CreateNewBtn_Click(object sender, EventArgs e)
        {
            //empty
            controller.ShowEditForm(-1);
        }
    }
}
