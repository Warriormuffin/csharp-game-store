using System;
namespace BCW.Store
{
    public class Shield : Item
    {
		public float DamageModifier { get; set; }

        public Shield( string name, string description, decimal price,  float damageModifier) : base ( name, description , price)
        {
            DamageModifier = damageModifier;

        }


        public float Block (float baseDamage)
        {
            var blockedDamage = baseDamage * DamageModifier;

            Console.WriteLine("Use" + Name + " to black " + blockedDamage + " damage.");

            return baseDamage - blockedDamage;
        }
        
    }
}
