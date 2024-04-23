namespace DesignPatterns.Decorator
{
    public class Decorator : Item
    {
        public Decorator(Item item)
        {
            this.item = item;
        }

        protected Item item;

        public override void Display()
        {
            item.Display();
        }
    }
}
