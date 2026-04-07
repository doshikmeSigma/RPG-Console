using RPG_Console.Entities;
using RPG_Console.Locations;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class MainMenu : Menu
    {
        public override string MenuCallPhrase => "MainMenu";
        protected override List<Menu> AvailableMenus { get; } = [];

        public MainMenu(Character character, Location location, Enemy enemy = null)
        {
            AvailableMenus.Add(new InventoryMenu(character));
            if (enemy != null)
            {
                AvailableMenus.Add(new InventoryMenu(enemy));
            }
            else
            {
                AvailableMenus.Add(new ExploreLocationMenu(character, location));
            }
        }
    }
}