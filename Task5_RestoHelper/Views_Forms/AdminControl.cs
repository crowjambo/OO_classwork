using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5RestoHelper.Forms
{
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            //load and init all of items from DB currenlty using ItemAdmin
            LoadItems();
        }

        private void LoadItems()
        {
            //use SQL DB access to load and then foreach loop

        }
    }
}
