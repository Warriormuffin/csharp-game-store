using System;
namespace BCW.Store
{
    public class Player
    {
        public string Name { get; set; }
        public int Heath { get; set; }
        public Inventory Inventory { get; set; }
        public Sword EquipedSword { get; set; }
        public Shield EquipedShield { get; set; }


        public void Attack()
        {
            
        }

        public void OnAttacked()
        {
            
        }

        public void EquipSword()
        {
            
        }

        public void EquipShield()
        {
            
        }

    }
}
