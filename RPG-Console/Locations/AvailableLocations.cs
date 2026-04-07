using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Locations
{
    public static class LocationManager
    {
        private static int IndexArrayOfLocations { get; set; } = 0;
        private static Location[] ArrayOfLocations =
        [
            new Dungeon()
        ];

        public static Location Get()
        {
            if (IndexArrayOfLocations < ArrayOfLocations.Length) return ArrayOfLocations[IndexArrayOfLocations++];
            else return null;
        }
    }
}
