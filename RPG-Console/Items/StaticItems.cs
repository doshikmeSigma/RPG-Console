using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace RPG_Console.Items
{
    public static class StaticItems
    {
        //public static readonly ImmutableDictionary<ItemType, Item> AllItems = ImmutableDictionary.Create<ItemType, Item>() тут надо объединить 2 нижних иммутабельных словаря
        public static readonly ImmutableDictionary<string, Weapon> AllWeapons = ImmutableDictionary.Create<string, Weapon>()
            .Add("zombiehands", new Weapon("ZombieHands", 10))
            .Add("sword", new Weapon("Sword", 20));

        //public static readonly ImmutableDictionary<ItemType, Armor> AllArmor = ImmutableDictionary.Create<ItemType, Armor>()
    }
}
