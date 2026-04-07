using System.ComponentModel;
using System.Runtime.CompilerServices;
using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public class Dungeon : Location
    {
        protected override string LocationName { get; } = "Dungeon";
        protected override string Description { get; } =
            "You've gone down to the dungeon\n" +
            "May the search for truth begin!";
        protected override List<Enemy> LocationEnemies { get; } = [];
        protected override List<Item> LocationItems { get; } =
        [
            StaticItems.Get(ItemId.Sword)
        ];
        protected override Enemy LocationBoss => throw new NotImplementedException();
    }
}
