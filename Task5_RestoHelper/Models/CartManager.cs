
























































using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5RestoHelper
{
    //controls collection of cart items, and sends data to populate the UI
    public class CartManager
    {
        //main cart collection
        public Dictionary<string, List<CartItem>> cartCollection;
        //main form it belongs to
        Form1 mainForm;

        public CartManager(Form1 form)
        {
            mainForm = form;
            cartCollection = new Dictionary<string, List<CartItem>>();
        }

        //Append new items to cart
        public void CreateNewItem(Item newItem)
        {
            //temp for appending to cartCollections lists
            List<CartItem> temp;

            //check for namestring in dictionary. If brand new, create it
            if (!cartCollection.ContainsKey(newItem.GetDishNameOnly()))
            {
                cartCollection.Add(newItem.GetDishNameOnly(), new List<CartItem>());
            }
            //add to new list matching name string
            cartCollection.TryGetValue(newItem.GetDishNameOnly(), out temp);
            temp.Add(new CartItem(newItem, this,1));


            //send to populate UI
            mainForm.RefreshCart(cartCollection);
        }

        //remove from collection and refresh
        public void RemoveItem(string dishNameKey)
        {
            //quick and easy way, will delete the whole stack, rather than 1 object
            cartCollection.Remove(dishNameKey);

            //send to populate UI
            mainForm.RefreshCart(cartCollection);
        }

        public double GetTotalWithoutVAT()
        {
            double sum = 0;
            foreach(var item in cartCollection.Values)
            {
               //now loop through list
               foreach(var dish in item)
                {
                    sum += dish.GetDishPrice();
                }
            }
            return Math.Round(sum,2);
        }

    }
}
