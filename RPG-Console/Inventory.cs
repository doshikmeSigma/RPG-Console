using System.CodeDom.Compiler;
using System.Collections;
using RPG_Console.Items;

namespace RPG_Console
{
    public class Inventory : IEnumerable<Item>
    {
        private List<Item> inventory = new List<Item>();

        public Item this[int index]
        {
            get => inventory[index];
            set => inventory[index] = value;
        }
        public Item this[Item item]
        {
            get
            {
                int index = inventory.IndexOf(item);
                if (index == -1) throw new KeyNotFoundException("Item not found in inventory");
                return inventory[index];
            }
            set
            {
                int index = inventory.IndexOf(item);
                if (index == -1) throw new KeyNotFoundException("Item not found in inventory");
                if (value == null) throw new ArgumentNullException(nameof(value));
                inventory[index] = value;
            }

        }

        public List<Item> GetAllItemsCopy()
        {
            return [.. inventory.Select(i => i.Clone())];
        }
        public void Add(Item item)
        {
            inventory.Add(item);
            inventory.Sort();
        }

        public void Remove(Item item)
        {
            inventory.Remove(item);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return inventory.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}