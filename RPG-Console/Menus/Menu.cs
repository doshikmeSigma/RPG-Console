using RPG_Console.Mobs;

namespace RPG_Console.Menus
{
    public abstract class Menu
    {
        public const int StartCursorPosition = 5;
        protected Character MainCharacter { get; } = Game.MainCharacter;
        public int CountAvailableMenus => AvailableMenus.Count;
        private int _currentCursorPosition = StartCursorPosition;
        public int CurrentCursorPosition
        {
            get => _currentCursorPosition;
            set
            {
                _currentCursorPosition = Math.Clamp
                (
                    value,
                    StartCursorPosition,
                    StartCursorPosition + (AvailableMenus.Count > 0 ? AvailableMenus.Count - 1 : 0)
                );
            }
        }

        public abstract string MenuCallPhrase { get; }
        protected abstract List<Menu> AvailableMenus { get; }

        public Menu this[int index] => AvailableMenus[index];

        public void ResetCursor()
        {
            CurrentCursorPosition = StartCursorPosition;
        }

        public virtual void Prepare() { ResetCursor(); }
        public virtual void OnRun() { }
        protected abstract Menu Clone();
    }
}
