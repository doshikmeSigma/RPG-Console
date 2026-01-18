using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class EquipMenu(Entity entity, Item item) : Menu(entity)
    {
        public override string MenuCallPhrase => "Equip";
        protected override List<Menu> AvailableMenus => [];

        public override void Prepare()
        {
            base.Prepare();
            Equip();
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(CurrentEntity, this);
            Console.ReadKey(true);
            if (item.AvailableEquipmentSlot == EquipmentSlot.None) MenuManager.HandleInput(ConsoleKey.Escape);
            else MenuManager.NavigateBackTo<InventoryMenu>();
        }

        public void DescripeEquipOfItem()
        {
            if (item.AvailableEquipmentSlot == EquipmentSlot.None)
            {
                Console.WriteLine("This item cannot be equipped\n");
                Console.WriteLine("Press any key to return");
            }
            else
            {
                Console.WriteLine($"You’ve equipped a {item.Name}");
            }
        }

        private void Equip()
        {
            if (item.AvailableEquipmentSlot != EquipmentSlot.None && CurrentEntity.Equipment[item.AvailableEquipmentSlot] != item)
            {
                EquipmentSlots equipmentSlots = CurrentEntity.Equipment;
                Inventory inventory = CurrentEntity.Inventory;

                Item oldItem = equipmentSlots[item.AvailableEquipmentSlot];
                equipmentSlots[item.AvailableEquipmentSlot] = item;
                inventory.Remove(item);
                if (oldItem.Id != ItemId.Fists) inventory.Add(oldItem);
            }
        }

        protected override Menu Clone()
        {
            return new EquipMenu(CurrentEntity, item);
        }
    }
}
