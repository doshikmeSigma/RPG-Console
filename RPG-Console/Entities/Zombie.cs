using RPG_Console.Entities;
using RPG_Console.Items;

namespace RPG_Console.Mobs
{
    public class Zombie : Enemy
    {
        public Zombie(string name, int healthPoint) : base(healthPoint, healthPoint, name)
        {
            Equipment[EquipmentSlot.MainHand] = StaticItems.Get(ItemId.ZombieHands);
        }

        public override Zombie Clone()
        {
            return new Zombie(Name, HealthPoint);    
        }
    }
}
