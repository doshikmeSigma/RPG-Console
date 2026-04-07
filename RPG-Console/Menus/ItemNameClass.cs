using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class ItemNameClass : Menu
    {
        public override string MenuCallPhrase { get; }
        protected override List<Menu> AvailableMenus { get; } = [];

        public ItemNameClass(Entity entity, Item item, string key = null)
        {
            MenuCallPhrase = key != null ? $"{key} > {item.Name} <" : item.Name;

            AvailableMenus.Add(new InspectMenu(item));
            if (entity is Character)
            {
                AvailableMenus.Add(new UseMenu(item));
                AvailableMenus.Add(new EquipMenu(item));
                AvailableMenus.Add(new DropMenu(item));
            }
        }
    }
}
