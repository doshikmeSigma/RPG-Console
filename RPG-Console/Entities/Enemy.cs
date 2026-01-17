using RPG_Console.Mobs;

namespace RPG_Console.Entities
{
    public abstract class Enemy : Entity, IPrototype<Enemy>
    {
        protected Enemy(int maxHealthPoint, int healthPoint, string name) : base(maxHealthPoint, healthPoint, name) { }

        public abstract Enemy Clone();
    }
}
