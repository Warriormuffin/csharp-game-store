﻿using System;

namespace BCW.Store.Tests
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Store Nathans = new Store("Nathans");
            Item pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20);
            Item shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200);
            Item sword = new Item("Knight's Sword", "A nice looking sword with an unknown emblem", 250);

            Nathans.AddItemToStore(pick);
			Nathans.AddItemToStore(shield);
            Nathans.AddItemToStore(sword);
            Nathans.RemoveItemsFromStore(sword);

            var MagicSword = new Sword("Magic Sword", "Master using it and you can have it.", 30, 70);

            MagicSword.Attack();
          
			var basicShield = new Shield("Basic Shield", "Provieds 10% Extra Defense", 10, .10f);

            basicShield.Block(100f);

			bool running = true;

			while (running)
			{
				Nathans.ViewItems();
                var item = Nathans.GetItemByName("Old Rusty");
                Console.WriteLine(item);
                Console.ReadLine();
				Nathans.AddItemToCart(item);
				Nathans.ViewCart();


				var total = Nathans.CalculateCartTotal();
                Console.WriteLine($"This is your cart total: {total}");
				Console.ReadLine();
				running = false;
			}

		}
    }
}
