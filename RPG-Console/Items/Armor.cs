using static System.Net.Mime.MediaTypeNames;

namespace RPG_Console.Items
{
    public class Armor(string name, int protection) : Item(name)
    {
        private readonly int _protection = protection;
        public int Protection { get { return _protection; } }

        public override Armor Clone()
        {
            return new Armor(Name, Protection);
        }
    }
}
