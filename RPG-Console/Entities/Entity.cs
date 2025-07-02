using RPG_Console.Items;

namespace RPG_Console.Mobs
{
    public abstract class Entity(int maxHealthPoint, int healthPoint, string name)
    {
        private readonly string _id = name.ToLower();
        public string ID { get { return _id; } }

        private readonly string _name = name;
        public string Name { get { return _name; } }

        public bool IsArmed { get; set; } = false;
            
        public EquipmentSlots Slots { get; } = new EquipmentSlots();

        public int MaxHealthPoint { get; protected set; } = maxHealthPoint;

        private int _healthPoint = healthPoint;
        public int HealthPoint
        {
            get { return _healthPoint; }
            set { _healthPoint = Math.Clamp(value, 0, MaxHealthPoint); }
        }

        public abstract Entity Clone();

        public void Attack(Entity entity)
        {
            if (Slots.MainHand is Weapon weapon)
            {
                entity.HealthPoint -= weapon.Damage;
            }
        }
    }

    public class EquipmentSlots
    {
        private Item _mainHand;
        public Item MainHand
        {
            get { return _mainHand; }
            set
            {
                if (StaticItems.ContainsKeyInItemTemplates(value.ID))
                {
                    _mainHand = value;
                }
            }
        }
    }
}