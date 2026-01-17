using RPG_Console.Items;

namespace RPG_Console
{
    public class EquipmentSlots
    {
        private Dictionary<EquipmentSlot, Item> EquipSlots = new()
        {
            [EquipmentSlot.MainHand] = StaticItems.Get(ItemId.Fists)
        };
        public Item this[EquipmentSlot equipmentSlot]
        {
            get => EquipSlots[equipmentSlot];
            set
            {
                if (StaticItems.Contains(value.Id))
                {
                    EquipSlots[equipmentSlot] = value;
                }
            }
        }

        public void ClearEquipmentSlot(EquipmentSlot equipmentSlot)
        {
            switch (equipmentSlot)
            {
                case EquipmentSlot.MainHand:
                    EquipSlots[equipmentSlot] = StaticItems.Get(ItemId.Fists);
                    break;
            }
        }

        public List<EquipmentSlot> GetAllSlots()
        {
            return [.. EquipSlots.Select(i => i.Key)];
        }
    }
    public enum EquipmentSlot
    {
        MainHand,
        None
    }
}