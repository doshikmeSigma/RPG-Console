using RPG_Console.Items;

namespace RPG_Console.Menus
{
    public class EquipMenu : Menu
    {
        private Item _item;
        public override string MenuCallPhrase => "Equip";
        protected override List<Menu> AvailableMenus => [];

        public EquipMenu(Item item)
        {
            _item = item;
        }

        public override void Prepare()
        {
            base.Prepare();
            Equip();
        }

        public override void OnRun()
        {
            ConsoleRenderer.Render(this);
            Console.ReadKey(true);
            if (_item.AvailableEquipmentSlot == EquipmentSlot.None) MenuManager.HandleInput(ConsoleKey.Escape);
            else MenuManager.NavigateBackTo<InventoryMenu>();
        }

        public void DescripeEquipOfItem()
        {
            if (_item.AvailableEquipmentSlot == EquipmentSlot.None)
            {
                Console.WriteLine("This item cannot be equipped\n");
                Console.WriteLine("Press any key to return");
            }
            else
            {
                Console.WriteLine($"You’ve equipped a {_item.Name}");
            }
        }

        private void Equip()
        {
            if (_item.AvailableEquipmentSlot != EquipmentSlot.None && MainCharacter.Equipment[_item.AvailableEquipmentSlot] != _item)
            {
                EquipmentSlots equipmentSlots = MainCharacter.Equipment;
                Inventory inventory = MainCharacter.Inventory;

                Item oldItem = equipmentSlots[_item.AvailableEquipmentSlot];
                equipmentSlots[_item.AvailableEquipmentSlot] = _item;
                inventory.Remove(_item);
                if (oldItem.Id != ItemId.Fists) inventory.Add(oldItem);
            }
        }

        protected override Menu Clone()
        {
            return new EquipMenu(_item);
        }
    }
}
