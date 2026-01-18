using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class MainMenu(Entity entity) : Menu(entity)
    {
        public override string MenuCallPhrase => "MainMenu";
        protected override List<Menu> AvailableMenus { get; } =
        [
            new InventoryMenu(entity)
        ];

        protected override Menu Clone()
        {
            return new MainMenu(CurrentEntity);
        }
    }
}