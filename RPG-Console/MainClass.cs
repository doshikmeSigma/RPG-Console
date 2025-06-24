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
            character.Slots.MainHand = StaticItems.AllWeapons["sword"];
            zombie.Slots.MainHand = StaticItems.AllWeapons["zombiehands"];
            Console.WriteLine(character.HealthPoint);
            zombie.Attack(character);
            Console.WriteLine(character.HealthPoint);
        }
    }
}