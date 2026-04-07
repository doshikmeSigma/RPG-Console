using RPG_Console.Items;

namespace RPG_Console.Mobs
{
    public abstract class Entity(int maxHealthPoint, int healthPoint, string name)
    {
        public string ID { get; } = name.ToLower();
        public string Name { get; } = name;
        public Inventory Inventory { get; } = new Inventory();
        public EquipmentSlots Equipment { get; } = new EquipmentSlots();
        public int MaxHealthPoint { get; private set; } = maxHealthPoint;
        private int _healthPoint = healthPoint;
        public int HealthPoint
        {
            get => _healthPoint;
            set => _healthPoint = Math.Clamp(value, 0, MaxHealthPoint);
        }

        public void Attack(Entity entity) => entity.HealthPoint -= ((Weapon)Equipment[EquipmentSlot.MainHand]).Damage;
    }
}