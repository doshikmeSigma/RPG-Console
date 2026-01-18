using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class ItemNameClass(Entity entity, Item item, string key = null) : Menu(entity)
    {
        public override string MenuCallPhrase => key != null ? $"{key} > {item.Name} <" : item.Name;
        protected override List<Menu> AvailableMenus { get; } =
        [
            new UseMenu(entity, item),
            new EquipMenu(entity, item),
            new InspectMenu(entity, item),
            new DropMenu(entity, item)
        ];

        protected override Menu Clone()
        {
            return new ItemNameClass(CurrentEntity, item, key);
        }
    }
}
