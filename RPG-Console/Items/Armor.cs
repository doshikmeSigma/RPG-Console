using static System.Net.Mime.MediaTypeNames;

namespace RPG_Console.Items
{
    public class Armor(string name, int protection) : Item(name, name.ToLower())
    {
        private readonly int _protection = protection;
        public int Protection { get { return _protection; } }
    }
}
