using RPG_Console.Menus;
using RPG_Console.Mobs;

namespace RPG_Console
{
    public static class ConsoleRenderer
    {
        public const int StartCursorPosition = 5;

        public static void DrawHUD(Entity entity)
        {
            Console.Clear();
            Console.WriteLine($"Name: {entity.Name}");
            Console.WriteLine($"HealthPoint: {entity.HealthPoint}/{entity.MaxHealthPoint}");
            if (entity is Character character)
            {
                Console.WriteLine($"Level: {character.Level}");
                Console.WriteLine($"Experience: {character.Experience}/{character.ExpToTheNextLevel}");
                Console.SetCursorPosition(0, StartCursorPosition);
            }
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

        public static void Render(Entity entity, Menu menu)
        {
            DrawHUD(entity);
            DrawMenu(menu);
        }
    }
}
