using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5RestoHelper.Models;
using Task5RestoHelper;

namespace Task5RestoHelper.Controllers
{
    class IntroScreenController
    {
        public IntroScreenController()
        {

        }


        //do login processing
        public User Login(string nickname, string password)
        {
            return SqliteDataAccess.LoginUser(nickname, password);
        }


        //do register processing
        public int RegisterUser(string nickname, string password)
        {
            return SqliteDataAccess.RegisterUser(nickname, password);
        }

        //Show Messagebox in UI
        public void CallMessageBox()
        {
            //do User checks in controller and call messages in the UI from here ( TO KEEP IT CLEAN LATER )
        }

        //update UI on View


        //load next view with User


    }
}
