namespace RPG_Console.Entities
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
