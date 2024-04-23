namespace DesignPatterns.Decorator
{
    public class Book : Item
    {
        public Book(string author, string title, int copies)
        {
            Author = author;
            Title = title;
            Copies = copies;
        }
        public string Author { get; private set; }
        public string Title { get; private set; }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", Author);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", Copies);
        }
    }
}
