using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class GUI
    {
        public static void CheckTheStats(Entity entity)
        {
            Console.Clear();
            Console.Write($"Name: {entity.Name}\n" +
                $"HealthPoint: {entity.HealthPoint}/{entity.MaxHealthPoint}\n");
            if (entity is Character character)
            {
                Console.Write($"Level: {character.Level}\n" +
                $"Experience: {character.Experience}/{character.ExpToTheNextLevel}\n");
            }    
        }

        public static void CheckTheInventory(Entity entity)
        {
            Console.Clear();
            if (entity.IsArmed)
            {
                Console.Write($"In the hands of the {entity.Name} is a {entity.Slots.MainHand.Name}");
            }
            else
            {
                Console.Write("The entity is unarmed");
            }
        }
    }
}
