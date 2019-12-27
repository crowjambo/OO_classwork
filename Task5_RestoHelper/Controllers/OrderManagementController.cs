using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5RestoHelper;

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

        // on view dish buttons click, send data to Cart/Basket model to update
        // on updated models, send signal to View to updae Cart/Basket part of the view

        // will hold models for dish list and cart
        // will have tie in functions to deal with models
        // will have trigger functions to update UI (Holds the View object, to call it)
    }
}
