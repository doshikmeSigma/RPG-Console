using System.Collections.Generic;
using System.Collections.Immutable;
using RPG_Console.Items.Effects;

namespace RPG_Console.Items
{
    public static class StaticItems
    {
        private readonly static ImmutableDictionary<ItemId, Item> ItemTemplates = ImmutableDictionary.Create<ItemId, Item>()
            // Standard weapon
            .Add(ItemId.Fists, new Weapon("Fists", ItemId.Fists, EquipmentSlot.MainHand, 15))
            .Add(ItemId.ZombieHands, new Weapon("ZombieHands", ItemId.ZombieHands, EquipmentSlot.MainHand, 10))

            // Weapon
            .Add(ItemId.Sword, new Weapon("Sword", ItemId.Sword, EquipmentSlot.MainHand, 20))

            // Armor
            .Add(ItemId.Helmet, new Armor("Helmet", ItemId.Helmet, EquipmentSlot.MainHand, 1))

            // Potion
            .Add(ItemId.HealthPotion, new Potion("HealthPotion", ItemId.HealthPotion, new HealingEffect(10)));

        public static Item Get(ItemId itemId) => ItemTemplates[itemId].Clone();

        public static bool Contains(ItemId itemId) => ItemTemplates.ContainsKey(itemId);
    }
    public enum ItemId
    {
        // Weapons
        Fists,
        Sword,
        ZombieHands,

        // Armor
        Helmet,

        // Potion
        HealthPotion
    }
}
