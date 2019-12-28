using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper.Forms;
using Task5RestoHelper.UserControls;

namespace Task5RestoHelper.Controllers
{
    public class AdminController
    {
        //views
        private AdminControl view;

        //models
        List<Dish> dishes = new List<Dish>();
        List<ItemAdmin> items = new List<ItemAdmin>();

        public AdminController(AdminControl view)
        {
            this.view = view;
            LoadData();
        }

        // load data from DB
        public void LoadData()
        {
            dishes = SqliteDataAccess.LoadDishes();
        }

        // Create admin items
        public void CreateItems()
        {
            foreach(Dish dish in dishes)
            {
                string temp = $"{dish.Id} {dish.DishName} {dish.DishDescription} {dish.Price}";
                items.Add(new ItemAdmin(temp,dish.Id));
            }
            
        }

        //return items for slaves
        public List<ItemAdmin> GetItems()
        {
            return items;
        }

        // send command to update view
        public void UpdateView()
        {
            view.UpdateView();
        }
    }
}
