using System.ComponentModel;
using System.Runtime.CompilerServices;
using RPG_Console.Entities;
using RPG_Console.Items;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public class Dungeon : Location
    {
        public Dungeon() : base
        (
            "Dungeon",

            "First level, location - dungeon\nTo move to the next level, " +
            "you need to kill 10 of any monsters and activate the teleport amulet to the boss location"
        )
        {
            LocationEntities = LocationEntities
                .Add("zombie", StaticEntities.Create<Zombie>("zombie"));

            LocationItems = LocationItems
                // Weapon
                .Add("sword", StaticItems.Create<Weapon>("sword"))
                // Armor
                .Add("helmet", StaticItems.Create<Armor>("helmet"));
        }
    }
}
