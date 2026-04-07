using System.Collections.Immutable;
using RPG_Console.Mobs;

namespace RPG_Console.Entities
{
    public static class StaticEntities
    {
        private readonly static ImmutableDictionary<EnemyId, Enemy> EntitiesTemplates = ImmutableDictionary.Create<EnemyId, Enemy>()
            .Add(EnemyId.Zombie, new Zombie("Zombie", 80));

        public static Enemy Get(EnemyId enemyId) => EntitiesTemplates[enemyId].Clone();
        public static bool Contains(EnemyId enemyId) => EntitiesTemplates.ContainsKey(enemyId);
    }

    public enum EnemyId
    {
        Zombie
    }
}
