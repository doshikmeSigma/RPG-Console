namespace RPG_Console.Items
{
    public class Weapon(string name, int damage) : Item(name, name.ToLower())
    {
        private readonly int _damage = damage;
        public int Damage { get { return _damage; } }
    }
}
