using RPG_Console.Entities;
using RPG_Console.Menus;
using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class ConsoleRenderer
    {
        private const int StartCursorPosition = 5;
        private static Character character { get; } = Game.MainCharacter;

        public static void DrawHUD()
        {
            Console.Clear();
            Console.WriteLine($"Name: {character.Name}");
            Console.WriteLine($"HealthPoint: {character.HealthPoint}/{character.MaxHealthPoint}");
            Console.WriteLine($"Level: {character.Level}");
            Console.WriteLine($"Experience: {character.Experience}/{character.ExpToTheNextLevel}");
            Console.SetCursorPosition(0, StartCursorPosition);
        }
        public static void DrawHUD(Enemy enemy)
        {
            Console.Clear();
            Console.Write($"Name: {character.Name}\t");
            Console.WriteLine($"Name: {enemy.Name}");
            Console.Write($"HealthPoint: {character.HealthPoint}/{character.MaxHealthPoint}\t");
            Console.WriteLine($"HealthPoint: {enemy.HealthPoint}/{enemy.MaxHealthPoint}");
            Console.WriteLine($"Level: {character.Level}");
            Console.WriteLine($"Experience: {character.Experience}/{character.ExpToTheNextLevel}");
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
                    return;
                case DropMenu:
                    ((DropMenu)menu).DescripeDropOfItem();
                    break;
                case ExploreLocationMenu:
                    ((ExploreLocationMenu)menu).DescripeRandomAction();
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
        public static void Render(Menu menu, Enemy enemy)
        {
            DrawHUD(enemy);
            DrawMenu(menu);
        }
    }
}
