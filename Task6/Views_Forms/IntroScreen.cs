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
            controller.view = this;
        }


        private void OpenNewForm(Form form)
        {
            form.ShowDialog();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {

            this.controller.RegisterUser(nicknameTextBox.Text, passwordTextBox.Text);

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            this.controller.Login(nicknameTextBox.Text, passwordTextBox.Text);
        }

        public void FailedLogin()
        {
            MessageBox.Show("Login failed");
            nicknameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        public void RegisterMessage(string message)
        {
            MessageBox.Show(message);
            nicknameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
