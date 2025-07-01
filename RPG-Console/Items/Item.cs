namespace RPG_Console.Items
{
    public abstract class Item(string name)
    {
        private readonly string _name = name;
        public string Name { get { return _name; } }

        private readonly string _id = name.ToLower();
        public string ID { get { return _id; } }

        public abstract Item Clone();
    }
}