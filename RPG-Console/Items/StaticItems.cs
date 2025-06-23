using System.Collections.Immutable;

namespace RPG_Console.Items
{
    public static class StaticItems
    {
        public static ImmutableArray<Item> AllItems { get; } = [.. AllWeapons.Cast<Item>(), .. AllArmor.Cast<Item>()];
        public static ImmutableArray<Weapon> AllWeapons { get; } =
        [
            new Weapon("ZombieHands", 10),
            new Weapon("Sword", 20)
        ];
        public static ImmutableArray<Armor> AllArmor { get; } =
        [

        ];
    }
}
