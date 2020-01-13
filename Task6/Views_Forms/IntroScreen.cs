using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper.Controllers;
using Task5RestoHelper.Models;

namespace Task5RestoHelper.Forms
{
    public partial class IntroScreen : Form
    {
        IntroScreenController controller;

        public IntroScreen()
        {
            InitializeComponent();
            this.controller = new IntroScreenController();
        }


        private void OpenNewForm(Form form)
        {
            form.ShowDialog();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            
            int test = this.controller.RegisterUser(nicknameTextBox.Text, passwordTextBox.Text);
            if(test != 0)
            {
                MessageBox.Show("Success! You can login now");
            }
            else
            {
                MessageBox.Show("Fail!");
      
            }
            nicknameTextBox.Text = "";
            passwordTextBox.Text = "";

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            User test = this.controller.Login(nicknameTextBox.Text, passwordTextBox.Text);
            if(test != null)
            {
                MessageBox.Show(test.Nickname + test.Password);
            }
            else
            {
                MessageBox.Show("Login failed");
                nicknameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
