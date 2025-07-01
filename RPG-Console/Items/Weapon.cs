namespace RPG_Console.Items
{
    public class Weapon(string name, int damage) : Item(name)
    {
        private readonly int _damage = damage;
        public int Damage { get { return _damage; } }

        public override Weapon Clone()
        {
            return new Weapon(Name, Damage);
        }
    }
}
