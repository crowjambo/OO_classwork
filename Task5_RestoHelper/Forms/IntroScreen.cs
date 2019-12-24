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
    public partial class IntroScreen : Form
    {
        public IntroScreen()
        {
            InitializeComponent();
        }

        private void AdminControlBtn_Click(object sender, EventArgs e)
        {
            AdminControl temp = new AdminControl();
            temp.Show();
        }

        private void OrderManageBtn_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }
    }
}
