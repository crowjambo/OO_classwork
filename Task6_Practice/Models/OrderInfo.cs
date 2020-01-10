using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5RestoHelper.Models
{
    public class OrderInfo
    {
        private string Date;
        private string totalVat;
        private string totalNoVat;

        public OrderInfo()
        {
            Date = String.Empty;
            totalNoVat = String.Empty;
            totalNoVat = String.Empty;
        }

        public string Date1 { get => Date; set => Date = value; }
        public string TotalVat { get => totalVat; set => totalVat = value; }
        public string TotalNoVat { get => totalNoVat; set => totalNoVat = value; }

    }
}
