using static System.Net.Mime.MediaTypeNames;

namespace RPG_Console.Items
{
    public class Armor(string name, ItemId itemId, EquipmentSlot availableEquipmentSlot, int protection) : Item(name, itemId, availableEquipmentSlot)
	{
        public int Protection { get; } = protection;

        public override Armor Clone()
        {
            return new Armor(Name, Id, AvailableEquipmentSlot, Protection);
        }
        public override string FullDescription()
        {
            return $"Name: {Name}\nProtection: {Protection}";
        }
    }
}
