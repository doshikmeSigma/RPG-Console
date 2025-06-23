using RPG_Console.Items;

namespace RPG_Console.Mobs
{
    public class Character(int healthPoint, string name) : Entity(healthPoint, healthPoint, name)
    {
        public int Experience { get; private set; } = 0;

        public int ExpToTheNextLevel { get; private set; } = 10;

        public int Level { get; private set; } = 1;

        public void AddExperience(int experience)
        {
            Experience += experience;
            while (Experience >= ExpToTheNextLevel)
            {
                Level++;
                Experience -= ExpToTheNextLevel;
                ExpToTheNextLevel += 10;
            }
        }
    }
}
