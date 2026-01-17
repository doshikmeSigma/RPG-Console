using RPG_Console.Items;

namespace RPG_Console.Mobs
{
    public class Character : Entity
    {
        public int Experience { get; private set; }
        public int ExpToTheNextLevel { get; private set; }
        public int Level { get; private set; }

        public Character(int healthPoint, string name) : base(healthPoint, healthPoint, name)
        {
            Experience = 0;
            ExpToTheNextLevel = 10;
            Level = 1;
            Equipment[EquipmentSlot.MainHand] = StaticItems.Get(ItemId.Fists);
        }   

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
