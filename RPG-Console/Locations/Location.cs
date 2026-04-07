using System.Collections.Immutable;
using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public abstract class Location()
    {
        protected static Random RandomGenerator = new Random();
        protected abstract string LocationName { get; }
        protected abstract string Description { get; }
        protected abstract List<Enemy> LocationEnemies { get; }
        protected abstract List<Item> LocationItems { get; }
        protected abstract Enemy LocationBoss { get; }

        public Enemy GetRandomEnemy()
        {
            Enemy randomEnemy = LocationEnemies[RandomGenerator.Next(LocationEnemies.Count)];
            LocationEnemies.Remove(randomEnemy);
            return randomEnemy;
        }
        public Item GetRandomItem()
        {
            Item randomItem = LocationItems[RandomGenerator.Next(LocationItems.Count)];
            LocationItems.Remove(randomItem);
            return randomItem;
        }
    }
}

