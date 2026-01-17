using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Locations;
using RPG_Console.Menus;
using RPG_Console.Mobs;
using System.Reflection.Metadata;
using System.Threading;

namespace RPG_Console
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game.StartGame();
            Character character = Game.MainCharacter;
            character.Inventory.Add(StaticItems.Get(ItemId.Sword));
            character.Inventory.Add(StaticItems.Get(ItemId.ZombieHands));
            character.Inventory.Add(StaticItems.Get(ItemId.HealthPotion));
            character.HealthPoint = 60;


            MenuState menuState = MenuState.Continue;
            while (menuState == MenuState.Continue)
            {
                menuState = MenuManager.Run();
            }
            Console.Clear();
            Console.WriteLine("You are out of the game");
        }
    }
}