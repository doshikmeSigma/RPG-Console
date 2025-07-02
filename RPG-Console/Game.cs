using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class Game
    {
        private static Character CharacterInitialization()
        {
            string nameCharacter;
            do
            {
                Console.Write("Enter your character's name: ");
                nameCharacter = Console.ReadLine();
                Console.Write($"Your name: {nameCharacter}. If you agree, then enter Y, otherwise - any character: ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
            } while (true);

            return new Character(100, nameCharacter);
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to the RPG Console game");
            Character mainCharacter = CharacterInitialization();
        }
    }
}
