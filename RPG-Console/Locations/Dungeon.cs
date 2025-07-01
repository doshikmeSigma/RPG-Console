using System.ComponentModel;
using System.Runtime.CompilerServices;
using RPG_Console.Mobs;

namespace RPG_Console.Locations
{
    public class Dungeon : Location
    {
        public Dungeon() : base
        (
            "Dungeon",
            "Первый уровень, локация - подземелье. Здесь обитают зомби.\n"
        )
        {
            LocationEntities = LocationEntities.Add("zombie", new Zombie(80, "Zombie"));
        }


    }
}
