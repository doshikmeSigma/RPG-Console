using RPG_Console.Items;

namespace RPG_Console.Menus
{
    public class UseMenu : Menu
    {
        private Item _item;

        public override string MenuCallPhrase => "Use";
        protected override List<Menu> AvailableMenus => [];

        public UseMenu(Item item)
        {
            _item = item;
        }

        public void DescripeUseOfItem()
        {
            if (_item is IUsable usableItem)
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
            if (_item is IUsable usableItem) MenuManager.NavigateBackTo<InventoryMenu>();
            else MenuManager.HandleInput(ConsoleKey.Escape);
        }

        private void Use()
        {
            if (_item is IUsable usableItem)
            {
                usableItem.UseItem();
                MainCharacter.Inventory.Remove(_item);
            }
        }

        protected override Menu Clone()
        {
            return new UseMenu(_item);
        }
    }
}
