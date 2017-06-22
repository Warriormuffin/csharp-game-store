using System;
namespace BCW.Store
{
	public class HealthPotion : Item
	{
		public decimal AddedHealth { get; set; }
        public decimal PlayerHealth { get; set; }

		public HealthPotion(string name, string description, decimal price, decimal addedHealth, decimal playerHealth) : base(name, description, price)
		{
            AddedHealth = addedHealth;
            PlayerHealth = playerHealth;

		}


		public decimal Heal()
		{
			var newHealth = PlayerHealth + AddedHealth;

            return newHealth;
		}

	}
}
