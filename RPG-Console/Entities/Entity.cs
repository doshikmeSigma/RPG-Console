using System.Collections.Generic;
using System.Xml.Linq;
using RPG_Console.Items;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_Console.Mobs
{
    public abstract class Entity(int maxHealthPoint, int healthPoint, string name)
    {
        private readonly string _id = name.ToLower();
        public string ID { get { return _id; } }

        private readonly string _name = name;
        public string Name { get { return _name; } }

        public bool IsArmed { get; set; } = false;

        public Inventory Inventory { get; } = new Inventory();

        public EquipmentSlots Equipment { get; } = new EquipmentSlots();

        public int MaxHealthPoint { get; protected set; } = maxHealthPoint;

        private int _healthPoint = healthPoint;
        public int HealthPoint
        {
            get { return _healthPoint; }
            set { _healthPoint = Math.Clamp(value, 0, MaxHealthPoint); }
        }

        public void Attack(Entity entity)
        {
            if (Equipment[EquipmentSlot.MainHand] is Weapon weapon)
            {
                entity.HealthPoint -= weapon.Damage;
            }
        }
    }
}