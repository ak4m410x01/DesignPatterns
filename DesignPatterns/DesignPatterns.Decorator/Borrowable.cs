namespace DesignPatterns.Decorator
{
    public class Borrowable : Decorator
    {
        protected readonly List<string> borrowers = new List<string>();

        public Borrowable(Item item) : base(item)
        {
        }

        public void Borrow(string name)
        {
            borrowers.Add(name);
            item.Copies--;
        }

        public void Return(string name)
        {
            borrowers.Remove(name);
            item.Copies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
