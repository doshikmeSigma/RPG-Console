using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class InspectMenu(Item item) : Menu
    {
        public override string MenuCallPhrase => "Inspect";
        protected override List<Menu> AvailableMenus => [];

        public void Inspect()
        {
            Console.WriteLine(item.FullDescription());
            Console.WriteLine("\nPress any key to return");
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(this);
            Console.ReadKey(true);
            MenuManager.HandleInput(ConsoleKey.Escape);
        }
    }
}
