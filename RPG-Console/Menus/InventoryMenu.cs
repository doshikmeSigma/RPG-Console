using RPG_Console.Items;

namespace RPG_Console.Menus
{
    public class InventoryMenu : Menu
    {
        public override string MenuCallPhrase { get; } = "Check the inventory";
        protected override List<Menu> AvailableMenus { get; } = [];

        public InventoryMenu()
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
            Inventory inventory = Game.MainCharacter.Inventory;
            EquipmentSlots equipmentSlots = Game.MainCharacter.Equipment;
            List<EquipmentSlot> slots = equipmentSlots.GetAllSlots();

            foreach (var slot in slots)
            {
                AvailableMenus.Add(new ItemNameClass(equipmentSlots[slot], slot.ToString()));
            }

            foreach (var item in inventory)
            {
                AvailableMenus.Add(new ItemNameClass(item));
            }
        }

        protected override Menu Clone()
        {
            return new InventoryMenu();
        }
    }
}
