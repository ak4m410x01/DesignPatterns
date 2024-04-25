namespace DesignPatterns.Mediator
{
    public class Participant
    {
        public Participant(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }

        public Chatroom? Chatroom { get; set; }

        public void Send(Participant destination, string message)
        {
            Chatroom?.Send(this, destination, message);
        }
        public void Receive(Participant source, string message)
        {
            Console.WriteLine($"\n'{source.Name}' say:\n\t '{message}'");
        }
    }
}
