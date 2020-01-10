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

namespace Task5RestoHelper.UserControls
{
    public partial class ItemAdmin : UserControl
    {
        private int id;
        private AdminController controller;


        public ItemAdmin(string allStringData, int id, AdminController controller)
        {
            InitializeComponent();
            ItemInfoLabel.Text = allStringData;
            this.id = id;
            this.controller = controller;
        }




        private void EditBtn_Click(object sender, EventArgs e)
        {
            //enter edit mode and pass the ID of item, to read in another form all the required data!
            controller.ShowEditForm(this.id);
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            controller.RemoveFromDatabase(this.id);
            MessageBox.Show("Removed");
        }
    }
}
