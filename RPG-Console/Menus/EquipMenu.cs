using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public class EquipMenu(Item item) : Menu
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
            ConsoleRenderer.Render(this);
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
            if (item.AvailableEquipmentSlot != EquipmentSlot.None && Game.MainCharacter.Equipment[item.AvailableEquipmentSlot] != item)
            {
                EquipmentSlots equipmentSlots = Game.MainCharacter.Equipment;
                Inventory inventory = Game.MainCharacter.Inventory;

                Item oldItem = equipmentSlots[item.AvailableEquipmentSlot];
                equipmentSlots[item.AvailableEquipmentSlot] = item;
                inventory.Remove(item);
                if (oldItem.Id != ItemId.Fists) inventory.Add(oldItem);
            }
        }
    }
}
