using System.Collections.Immutable;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Entities
{
    public static class StaticEntities
    {
        private readonly static ImmutableDictionary<string, Enemy> EntitiesTemplates = ImmutableDictionary.Create<string, Enemy>()
            .Add("zombie", new Zombie("Zombie", 80));

        public static Entity Create(string id)
        {
            return EntitiesTemplates[id].Clone();
        }

        public static bool ContainsKeyInEntitiesTemplates(string id)
        {
            if (EntitiesTemplates.ContainsKey(id))
            {
                return true;
            }
            return false;
        }
    }
}
