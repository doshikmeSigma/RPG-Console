using System.Collections.Immutable;

namespace RPG_Console.Items
{
    public static class StaticItems
    {
        private readonly static ImmutableDictionary<string, Item> ItemTemplates = ImmutableDictionary.Create<string, Item>()
            // Weapons
            .Add("zombiehands", new Weapon("ZombieHands", 10))
            .Add("sword", new Weapon("Sword", 20))
            // Armor
            .Add("helmet", new Armor("Helmet", 1));

        public static T Create<T>(string id)
        {
            if (ItemTemplates[id].Clone() is T t)
            {
                return t;
            }
            else
            {
                throw new InvalidCastException($"В шаблоне отсутствует предмет такого типа");
            }
        }

        public static bool ContainsKeyInItemTemplates(string id)
        {
            if (ItemTemplates.ContainsKey(id))
            {
                return true;
            }
            return false;
        }
    }
}
