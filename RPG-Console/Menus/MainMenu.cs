namespace RPG_Console.Menus
{
    public class MainMenu : Menu
    {
        public override string MenuCallPhrase => "MainMenu";
        protected override List<Menu> AvailableMenus { get; } =
        [
            new InventoryMenu()
        ];

        protected override Menu Clone()
        {
            return new MainMenu();
        }
    }
}