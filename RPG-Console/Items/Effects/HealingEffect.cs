namespace RPG_Console.Items.Effects
{
    public class HealingEffect(int health) : IEffect
    {
        public void Apply()
        {
            Game.MainCharacter.HealthPoint += health;
        }

        public string GetEffectDescription()
        {
            return $"Restores {health} health";
        }

        public void GetUsageDescription()
        {
            Console.WriteLine($"You drank the potion\n{health} health restored");
        }
    }
}
