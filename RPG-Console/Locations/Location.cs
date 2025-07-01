using System.Collections.Immutable;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public abstract class Location(string locationName, string description)
    {
        private readonly string _locationName = locationName;
        public string LocationName { get { return _locationName; } }

        private readonly string _description = description;
        public string Description { get { return _description; } }

        protected ImmutableDictionary<string, Entity> LocationEntities = ImmutableDictionary<string, Entity>.Empty;

        protected ImmutableDictionary<string, Item> LocationItems = ImmutableDictionary<string, Item>.Empty;
    }
}
