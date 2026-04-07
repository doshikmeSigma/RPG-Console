using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Locations;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class ExploreLocationMenu(Character character, Location location) : Menu
    {
        protected const int NumberOfSelections = 2;
        public override string MenuCallPhrase => "Explore location";
        protected override List<Menu> AvailableMenus { get; } = [];
        protected string DescriptionRandomAction { get; private set; } = "";

        public override void OnRun()
        {
            switch (new Random().Next(NumberOfSelections))
            {
                case 0:
                    Item randomLocationItem = location.GetRandomItem();
                    character.Inventory.Add(randomLocationItem);
                    DescriptionRandomAction =
                        "You found the chest\n" +
                        $"There was a {randomLocationItem.Name} in the chest\n" +
                        "Press any button to continue";
                    ConsoleRenderer.Render(this);
                    Console.ReadKey(true);
                    MenuManager.HandleInput(ConsoleKey.Escape);
                    break;
                case 1:
                    MenuManager.Clear();
                    Enemy enemy = location.GetRandomEnemy();
                    MenuManager.Push(new MainMenu(character, location, enemy));
                    DescriptionRandomAction =
                       $"You've been attacked by {enemy.Name}!";
                    ConsoleRenderer.Render(this);
                    Console.ReadKey(true);
                    break;
            }
        }
        public void DescripeRandomAction()
        {
            Console.WriteLine(DescriptionRandomAction);
        }
    }
}
