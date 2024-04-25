namespace DesignPatterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom participants
            var George = new Beatle("1", "George");
            var Paul = new Beatle("2", "Paul");
            var Ringo = new Beatle("3", "Ringo");
            var John = new Beatle("4", "John");
            var Yoko = new Beatle("5", "Yoko");

            // Create chatroom and register participants
            Chatroom chatroom = new("Programming Channel");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);


            // Chatting participants
            George.Send(Ringo, "Hi, Ringo");
            George.Send(Paul, "Hi, Paul");
            John.Send(George, "Hi, George");
            George.Send(John, "Hi, John");
        }
    }
}
