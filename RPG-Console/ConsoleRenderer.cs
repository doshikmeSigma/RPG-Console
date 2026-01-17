using RPG_Console.Menus;
using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class ConsoleRenderer
    {
        public const int StartCursorPosition = 5;
        private static Character MainCharacter { get; } = Game.MainCharacter;

        public static void DrawHUD()
        {
            Console.Clear();
            Console.WriteLine($"Name: {Game.MainCharacter.Name}");
            Console.WriteLine($"HealthPoint: {MainCharacter.HealthPoint}/{MainCharacter.MaxHealthPoint}");
            Console.WriteLine($"Level: {MainCharacter.Level}");
            Console.WriteLine($"Experience: {MainCharacter.Experience}/{MainCharacter.ExpToTheNextLevel}");
            Console.SetCursorPosition(0, StartCursorPosition);
        }

        public static void DrawMenu(Menu menu)
        {
            switch (menu)
            {
                case UseMenu:
                    ((UseMenu)menu).DescripeUseOfItem();
                    return;
                case EquipMenu:
                    ((EquipMenu)menu).DescripeEquipOfItem();
                    return;
                case InspectMenu:
                    ((InspectMenu)menu).Inspect();
                    Console.WriteLine("\nPress any key to return");
                    return;
                case DropMenu:
                    ((DropMenu)menu).DescripeDropOfItem();
                    break;
            }

            for (int i = 0; i < menu.CountAvailableMenus; i++)
            {
                if (menu.CurrentCursorPosition == StartCursorPosition + i)
                {
                    Console.WriteLine($"[ {menu[i].MenuCallPhrase} ]");
                }
                else
                {
                    Console.WriteLine(menu[i].MenuCallPhrase);
                }
            }
        }

        public static void Render(Menu menu)
        {
            DrawHUD();
            DrawMenu(menu);
        }
    }
}
