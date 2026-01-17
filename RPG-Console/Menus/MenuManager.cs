namespace RPG_Console.Menus
{
    public static class MenuManager
    {
        private static readonly Stack<Menu> Menus = new();
        public const int StartCursorPosition = 5;

        static MenuManager()
        {
            Menus.Push(new MainMenu());
        }

        private static void Push(Menu menu)
        {
            menu.Prepare();
            Menus.Push(menu);
        }

        public static MenuState HandleInput(ConsoleKey key)
        {
            Menu currentMenu = Menus.Peek();
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentMenu.CurrentCursorPosition--;
                    return MenuState.Scrolling;
                case ConsoleKey.DownArrow:
                    currentMenu.CurrentCursorPosition++;
                    return MenuState.Scrolling;
                case ConsoleKey.Enter:
                    int indexSelectedMenu = currentMenu.CurrentCursorPosition - StartCursorPosition;
                    Push(currentMenu[indexSelectedMenu]);
                    return MenuState.Forward;
                case ConsoleKey.Escape:
                    Menus.Pop();
                    return MenuState.Back;
            }
            return MenuState.InvalidInput;
        }

        public static void NavigateBackTo<T>() where T : Menu
        {
            while (Menus.Peek() is not T) Menus.Pop();
            Menus.Peek().Prepare();
        }

        public static MenuState Run()
        {
            if (Menus.Count == 0) return MenuState.Exit;

            Menus.Peek().OnRun();
            ConsoleRenderer.Render(Menus.Peek());
            HandleInput(Console.ReadKey(true).Key);

            return MenuState.Continue;
        }
    }

    public enum MenuState
    {
        Scrolling,
        Forward,
        Back,
        InvalidInput,
        Exit,
        Continue
    }
}
