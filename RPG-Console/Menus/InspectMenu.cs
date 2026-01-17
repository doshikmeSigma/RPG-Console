using System.Runtime.CompilerServices;
using RPG_Console.Items;

namespace RPG_Console.Menus
{
    public class InspectMenu(Item item) : Menu
    {
        public override string MenuCallPhrase => "Inspect";
        protected override List<Menu> AvailableMenus => [];

        public void Inspect()
        {
            Console.WriteLine(item.FullDescription());
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(this);
            Console.ReadKey(true);
            MenuManager.HandleInput(ConsoleKey.Escape);
        }

        protected override Menu Clone()
        {
            return new InspectMenu(item);
        }
    }
}
