using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5RestoHelper
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }
        public int Category { get; set; }

        public Dish()
        {

        }

        public Dish(int id, string name, string description, string picURL, double price, int category)
        {
            this.Id = id;
            this.DishName = name;
            this.DishDescription = description;
            this.Picture = picURL;
            this.Price = price;
            this.Category = category;
        }
    }
}
