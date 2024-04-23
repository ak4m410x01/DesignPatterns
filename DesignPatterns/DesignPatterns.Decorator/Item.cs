namespace DesignPatterns.Decorator
{
    public abstract class Item
    {
        public int Copies { get; set; }
        public abstract void Display();
    }
}
