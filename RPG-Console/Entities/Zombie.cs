using RPG_Console.Items;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_Console.Mobs
{
    public class Zombie : Entity
    {
        public Zombie(string name, int healthPoint) : base(healthPoint, healthPoint, name)
        {
            Slots.MainHand = StaticItems.Create<Weapon>("zombiehands");
        }

        public override Zombie Clone()
        {
            return new Zombie(Name, HealthPoint);    
        }
    }
}
