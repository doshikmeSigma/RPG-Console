using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class InventoryMenu : Menu
    {
        public override string MenuCallPhrase { get; } = "Check the inventory";
        protected override List<Menu> AvailableMenus { get; } = [];

        public InventoryMenu(Entity entity) : base(entity)
        {
            BuildMenu();
        }

        public override void Prepare()
        {
            ResetCursor();
            BuildMenu();
        }

        public void BuildMenu()
        {
            AvailableMenus.Clear();
            Inventory inventory = CurrentEntity.Inventory;
            EquipmentSlots equipmentSlots = CurrentEntity.Equipment;
            List<EquipmentSlot> slots = equipmentSlots.GetAllSlots();

            foreach (var slot in slots)
            {
                AvailableMenus.Add(new ItemNameClass(CurrentEntity, equipmentSlots[slot], slot.ToString()));
            }

            foreach (var item in inventory)
            {
                AvailableMenus.Add(new ItemNameClass(CurrentEntity, item));
            }
        }

        protected override Menu Clone()
        {
            return new InventoryMenu(CurrentEntity);
        }
    }
}
