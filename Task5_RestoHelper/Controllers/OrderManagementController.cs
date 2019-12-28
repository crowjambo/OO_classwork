using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper;
using Task5RestoHelper.Models;

namespace Task5RestoHelper.Controllers
{
    public class OrderManagementController
    {
        //models
        private List<Dish> dishes;
        private Cart cart;
        private List<Item> items;
        //view
        private Form1 view;

        public OrderManagementController(Form1 view)
        {
            this.view = view;
            LoadData();
            this.cart = new Cart();
            this.items = new List<Item>();
        }

        // load data from DB
        public void LoadData()
        {
            dishes = SqliteDataAccess.LoadDishes();
            
        }

        // send it to View to diplay dishes list
        public void UpdateView()
        {
            view.UpdateDishes();
        }

        // create items from dishes DB
        public void CreateItems()
        {
            foreach (var dish in dishes)
            {
                Item newItem = new Item(dish.DishName, dish.Picture, dish.Price, dish.DishDescription, this);
                items.Add(newItem);
            }
        }

        public void UpdateCart()
        {
            view.UpdateCart();
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public Cart GetCart()
        {
            return cart;
        }

        // save receipt with DI
        public void Save(IOrderSave saver, OrderInfo info)
        {
            saver.Save(info);
        }


    }
}
