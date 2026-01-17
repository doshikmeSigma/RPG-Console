namespace RPG_Console.Items
{
    public class Weapon(string name, ItemId itemId, EquipmentSlot availableEquipmentSlot, int damage) : Item(name, itemId, availableEquipmentSlot)
    {
        public int Damage { get; } = damage;

        public override Weapon Clone()
        {
            return new Weapon(Name, Id, AvailableEquipmentSlot, Damage);
        }
        public override string FullDescription()
        {
            return $"Name: {Name}\nDamage: {Damage}";
        }
    }
}
