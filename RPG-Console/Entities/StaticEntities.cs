using System.Collections.Immutable;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Entities
{
    public static class StaticEntities
    {
        private readonly static ImmutableDictionary<string, Entity> EntitiesTemplates = ImmutableDictionary.Create<string, Entity>()
            .Add("zombie", new Zombie("Zombie", 80));

        public static T Create<T>(string id)
        {
            if (EntitiesTemplates[id].Clone() is T t)
            {
                return t;
            }
            else
            {
                throw new InvalidCastException($"В шаблоне отсутствует существо такого типа");
            }
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
