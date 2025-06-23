namespace RPG_Console.Items
{
    public abstract class Item(string name, string id)
    {
        private readonly string _name = name;
        public string Name { get { return _name; } }

        private readonly string _id = id;
        public string ID { get { return _id; } }
    }
}
