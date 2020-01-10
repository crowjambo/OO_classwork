using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper.Forms;

namespace Task5RestoHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //this will let us return data from IntroScreen form
            using (var form = new IntroScreen())
            {
                Application.Run(form);
                //example usage
                //MessageBox.Show(form.ReturnValueTest);
            }
            
        }
    }
}
