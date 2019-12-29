using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper.Forms;
using Task5RestoHelper.UserControls;
using Task5RestoHelper;

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
            //clear previous just in case
            items.Clear();

            foreach(Dish dish in dishes)
            {
                string temp = $"{dish.Id} {dish.DishName} {dish.DishDescription} {dish.Price}";
                items.Add(new ItemAdmin(temp,dish.Id,this));
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
            LoadData();
            CreateItems();
            view.UpdateView();
        }

        // open a form for editing using variables
        public void ShowEditForm(int id)
        {
            //empty overload constructor
            ItemEditAdd form = new ItemEditAdd(id,this);
            form.ShowDialog();
        }

        // submit to DB update or new 
        public void UpdateDatabase(int id, string dishName, string description, string picURL,double price, int category)
        {

            Dish temp = new Dish(id, dishName, description, picURL, price, category);

            // if sent object id -1 (brand new)
            if(id == -1)
            {
                SqliteDataAccess.CreateNewDish(temp);
            }
            else
            {
                SqliteDataAccess.UpdateDishDb(temp);
            }
           
   
            // update main view form
            UpdateView();
        }

        public void RemoveFromDatabase(int id)
        {
            SqliteDataAccess.RemoveDish(id);

            // update main view form
            UpdateView();
        }

        // using sqldata access, get one dish using ID look up
        public Dish DatabaseLookUp(int id)
        {
            return SqliteDataAccess.LoadDish(id);
        }
    }
}
