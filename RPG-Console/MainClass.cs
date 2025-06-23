using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Character character = new Character(100, "Sigma");
            Zombie zombie = new Zombie(50, "Nythree");
            character.Slots.MainHand = StaticItems.AllWeapons[1];
            zombie.Slots.MainHand = StaticItems.AllWeapons[0];
        }
    }
}