using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class InspectMenu(Entity entity, Item item) : Menu(entity)
    {
        public override string MenuCallPhrase => "Inspect";
        protected override List<Menu> AvailableMenus => [];

        public void Inspect()
        {
            Console.WriteLine(item.FullDescription());
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(CurrentEntity, this);
            Console.ReadKey(true);
            MenuManager.HandleInput(ConsoleKey.Escape);
        }

        protected override Menu Clone()
        {
            return new InspectMenu(CurrentEntity, item);
        }
    }
}
