namespace DesignPatterns.Mediator
{
    public interface IChatroom
    {
        public void Register(Participant participant);
        public void Send(Participant source, Participant destination, string message);
    }
}
