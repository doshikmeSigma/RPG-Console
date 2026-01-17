using RPG_Console.Items;

namespace RPG_Console.Menus
{
    public class ItemNameClass(Item item, string key = null) : Menu
    {
        public override string MenuCallPhrase => key != null ? $"{key} > {item.Name} <" : item.Name;
        protected override List<Menu> AvailableMenus { get; } =
        [
            new UseMenu(item),
            new EquipMenu(item),
            new InspectMenu(item),
            new DropMenu(item)
        ];

        protected override Menu Clone()
        {
            return new ItemNameClass(item, key);
        }
    }
}
