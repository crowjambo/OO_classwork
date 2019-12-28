using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5RestoHelper;
using Task5RestoHelper.Models;

namespace Task5RestoHelper
{
    public interface IOrderSave
    {
        void Save(OrderInfo info);
    }
}
