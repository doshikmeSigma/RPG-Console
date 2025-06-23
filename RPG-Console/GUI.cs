using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class GUI
    {
        public static void CheckTheStats(Character character)
        {
            Console.Clear();
            Console.Write($"Name: {character.Name}\n" +
                $"Level: {character.Level}\n" +
                $"Experience: {character.Experience}/{character.ExpToTheNextLevel}\n" +
                $"HealthPoint: {character.HealthPoint}/{character.MaxHealthPoint}\n");
        }
    }
}
