namespace DesignPatterns.Mediator
{
    public class Chatroom : IChatroom
    {
        public Chatroom(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        private readonly Dictionary<string, Participant> _participants = [];

        public void Register(Participant participant)
        {
            if (!_participants.ContainsKey(participant.Id))
            {
                participant.Chatroom = this;
                _participants.Add(participant.Id, participant);
            }
        }

        public void Send(Participant source, Participant destination, string message)
        {
            if (!_participants.ContainsKey(source.Id))
            {
                Console.WriteLine($"{source.Id} {source.Name} not a Participant in {Name} Chatroom.");
                return;
            }
            if (!_participants.ContainsKey(destination.Id))
            {
                Console.WriteLine($"{destination.Id} {destination.Name} not a Participant in {Name} Chatroom.");
                return;
            }

            destination.Receive(source, message);
        }
    }
}
