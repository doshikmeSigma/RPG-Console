namespace RPG_Console.Items
{
    public class Potion : Item, IUsable
    {
        private IEffect Effect { get; }

        public Potion(string name, ItemId itemId, IEffect effect) : base(name, itemId, EquipmentSlot.None)
        {
            Effect = effect;
        }

        public override Potion Clone()
        {
            return new Potion(Name, Id, Effect);
        }

        public void DescribeUse()
        {
            Effect.GetUsageDescription();
        }

        public void UseItem()
        {
            Effect.Apply();
        }

        public override string FullDescription()
        {
            return $"Name: {Name}\n" + Effect.GetEffectDescription();
        }
    }
}
