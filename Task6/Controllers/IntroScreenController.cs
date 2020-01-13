using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5RestoHelper.Models;
using Task5RestoHelper;
using Task5RestoHelper.Forms;

namespace Task5RestoHelper.Controllers
{
    class IntroScreenController
    {
        //get logged in user to send to next form
        public User user;

        //view access
        public IntroScreen view;

        public IntroScreenController()
        {

        }


        //do login processing
        public void Login(string nickname, string password)
        {
            User test = SqliteDataAccess.LoginUser(nickname, password);

            if (test != null)
            {
                this.user = test;
                LoadNextView();
            }
            else
            {
                view.FailedLogin();
            }
        }


        //do register processing
        public void RegisterUser(string nickname, string password)
        {
            int test = SqliteDataAccess.RegisterUser(nickname, password);
            if (test != 0)
            {
                view.RegisterMessage("Success!");
            }
            else
            {
                view.RegisterMessage("Fail");

            }
        }

        //load next view with User
        public void LoadNextView()
        {
            //admin
            if(user.accessLevel == 0)
            {
                AdminControl form = new AdminControl(user);
                form.ShowDialog();
            }
            else
            {
                Form1 form = new Form1(user);
                form.ShowDialog();
            }
        }

    }
}
