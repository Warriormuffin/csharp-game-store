using System;
namespace BCW.Store
{
    public class Sword : Item
    {
		public decimal Damage { get; set; }

        public Sword(string name, string description, decimal price, decimal damage) : base (name, description, price) 
        {
          
            Damage = damage;
            
        }



        
        public void Attack()
        {
            Console.WriteLine(("Swing " + Name + "deal " + Damage + " Damages"));
        }
       
    }
}
