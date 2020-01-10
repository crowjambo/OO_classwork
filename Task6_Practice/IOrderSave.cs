using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6Practice;
using Task6Practice.Models;

namespace Task6Practice
{
    public interface IOrderSave
    {
        void Save(OrderInfo info);
    }
}
