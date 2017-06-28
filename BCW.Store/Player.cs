using System;
using System.Collections.Generic;

namespace BCW.Store
{
    public class Player
    {
        private List<Item> inventory { get; set; }
        public string Name { get; set; }
        public int Heath { get; set; }
        public Sword EquipedSword { get; set; }
        public Shield EquipedShield { get; set; }

        public Player()
        {
            inventory = new List<Item>();

        }

        public void Attack()
        {
            if(EquipedSword != null){
                EquipedSword.Attack();
            }
            else
            {
                Console.WriteLine("Player has no Sword... Throws punch instead. Deal: 1 damage");
            }
            
        }

        public void OnAttacked()
        {
            var attackDamage = 10;
            if(EquipedShield != null){
                  var reducedDamage = EquipedShield.Block(attackDamage);
                    var newHealth = Heath - reducedDamage;
            }
            else
            {
               Console.WriteLine("You should purchase a Shield from the store"); 
            }
            
        }

        public void EquipSword()
        {

				foreach (var item in inventory)
				{
					if (item is Sword)
					{
						EquipedSword = (item as Sword);
					}
				}

			}
           

        public void EquipShield()
        {
            foreach (var item in inventory)
            {
                if (item is Shield)
                {
                    EquipedShield = (item as Shield);
                }
            }
            
        }

        public class Inventory
        {
        }
    }
}
