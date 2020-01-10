using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6Practice;
using Task6Practice.Models;
using System.IO;
using System.Text;

namespace Task6Practice
{
    class FileDataAccess : IOrderSave
    {

        public void Save(OrderInfo info)
        {
            //AppDomain.CurrentDomain.BaseDirectory + @"\" + fileName
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "Ordersbackup.txt";


            File.AppendAllText(path, info.Date1 + ";");
            File.AppendAllText(path, info.TotalVat + ";");
            File.AppendAllText(path, info.TotalNoVat + "\n");

        }
    }
}
