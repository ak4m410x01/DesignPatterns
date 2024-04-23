namespace DesignPatterns.Decorator
{
    public class Video : Item
    {
        public Video(string director, string title, int playTime, int copies)
        {
            Director = director;
            Title = title;
            PlayTime = playTime;
            Copies = copies;
        }

        public string Director { get; private set; }
        public string Title { get; private set; }
        public int PlayTime { get; private set; }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", Director);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", Copies);
            Console.WriteLine(" Playtime: {0}\n", PlayTime);
        }
    }
}
