using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class UseMenu(Item item) : Menu
    {
        public override string MenuCallPhrase => "Use";
        protected override List<Menu> AvailableMenus => [];

        public void DescripeUseOfItem()
        {
            if (item is IUsable usableItem)
            {
                usableItem.DescribeUse();
            }
            else
            {
                Console.WriteLine("This item cannot be used\n");
                Console.WriteLine("Press any key to return");
            }
        }

        public override void Prepare()
        {
            base.Prepare();
            Use();
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(this);
            Console.ReadKey(true);
            if (item is IUsable) MenuManager.NavigateBackTo<InventoryMenu>();
            else MenuManager.HandleInput(ConsoleKey.Escape);
        }

        private void Use()
        {
            if (item is IUsable usableItem)
            {
                usableItem.UseItem();
                Game.MainCharacter.Inventory.Remove(item);
            }
        }
    }
}
