using System;
using System.Collections.Generic;
using System.Linq;

namespace BCW.Store
{
    public class Store
    {
        public string Name { get; set; }
        public Item MyItem { get; set; }
		private List<Item> Items = new List<Item>();
        private List<Item> Cart = new List<Item>();
        public Store(string name)
        {
            Name = name;
        }

                 

        public void AddItemToStore(Item item) 
        {
            
			Items.Add(item);
        }

        public void SetMyItemByName(string itemName)
        {
            foreach (var i in Items)
            {
                if (i.Name == itemName)
                {
                    MyItem =  i;
                }
            }
        }

        public Item GetItemByName(string name)
        {
            
            foreach (var item in Items)
            {
                if(name == item.Name)
                {
                    return item;
                }
            }

            return null;
        }

        public void RemoveItemsFromStore(Item item)
        {
            var itemToRemove = Items.FirstOrDefault(items => items.Name == item.Name);

            Items.Remove(itemToRemove);
        }

            //public string CartName { get; set; }


		    //public void Cart(string cartName)
		    //{
      //      CartName = cartName;
			
		    //}

            public void AddItemToCart(Item item)

            {
              
				    Cart.Add(item); 
            }

            public void RemoveItemFromCart(Item item)
            {
			    var itemToRemove = Items.FirstOrDefault(items => items.Name == item.Name);

			    Cart.Remove(itemToRemove);
                
            }

            public decimal CalculateCartTotal()
            {
                return Cart.Sum(i => i.Price);
            }

            public void ViewItems()
            {
                Console.WriteLine("Welcome to the Store");
                Console.WriteLine("Below are the items you can purchase from the Store");

            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                Console.WriteLine($"{i + 1}: {item.Name} {item.Description} {item.Price}");
            }
        }

            public void ViewCart()
        {
			Console.WriteLine("Welcome to your Car");
			Console.WriteLine("Below are the items in Cart");



            for (int i = 0; i < Cart.Count; i++)
            {
                var item = Cart[i];
                Console.WriteLine($"{i + 1}: {item.Name} {item.Description} {item.Price}");
            }
        }
    }
}
