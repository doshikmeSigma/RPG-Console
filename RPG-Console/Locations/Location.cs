using System.Collections.Immutable;
using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public abstract class Location()
    {
        protected string LocationName { get; }
        protected string Description { get; }
        protected List<Entity> LocationEntities { get; } = [];
        protected List<Item> LocationItems { get; } = [];

        public void ShowLocationDescription()
        {
            Console.WriteLine(Description);
        }
    }
}
