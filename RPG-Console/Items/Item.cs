using System.Collections.Immutable;

namespace RPG_Console.Items
{
    public abstract class Item(string name, ItemId itemId, EquipmentSlot availableEquipmentSlot) : IComparable<Item>
    {
        public string Name { get; } = name;
        public ItemId Id { get; } = itemId;
        public EquipmentSlot AvailableEquipmentSlot { get; } = availableEquipmentSlot;

        public int CompareTo(Item item)
        {
            if (item == null) return 1;
            return Id.CompareTo(item.Id);
        }

        public abstract string FullDescription();
        public abstract Item Clone();
    }
}