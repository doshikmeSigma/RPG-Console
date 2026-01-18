using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class DropMenu(Entity entity, Item item) : Menu(entity)
    {
        public override string MenuCallPhrase => "Drop";
        protected override List<Menu> AvailableMenus => [];

        protected override Menu Clone()
        {
            return new DropMenu(CurrentEntity, item);
        }

        public void DescripeDropOfItem()
        {
            Console.WriteLine($"Do you want to throw away the {item.Name}?\nPress Enter to confirm this, otherwise any key");
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(CurrentEntity, this);
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Drop();
                MenuManager.NavigateBackTo<InventoryMenu>();
            }
            else MenuManager.HandleInput(ConsoleKey.Escape);
        }

        private void Drop()
        {
            EquipmentSlots equipmentSlots = CurrentEntity.Equipment;
            EquipmentSlot equipmentSlot = item.AvailableEquipmentSlot;
            if (equipmentSlot != EquipmentSlot.None && item == equipmentSlots[equipmentSlot]) equipmentSlots.ClearEquipmentSlot(equipmentSlot);
            else CurrentEntity.Inventory.Remove(item);
        }
    }
}
