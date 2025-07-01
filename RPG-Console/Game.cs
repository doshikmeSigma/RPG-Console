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
                Console.Write("Введите имя вашего персонажа: ");
                nameCharacter = Console.ReadLine();
                Console.Write($"Ваше имя: {nameCharacter}. Если согласны, то введите Y, иначе - любой символ: ");
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
            Console.WriteLine("Добро пожаловать в игру RPG Console");
            Character mainCharacter = CharacterInitialization();
        }
    }
}
