namespace DesignPatterns.Command
{
    public class Receiver
    {
        public Receiver(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Money { get; private set; } = 0;

        public void SendMoney(decimal money)
        {
            Money += money;

            // Logging
            Console.WriteLine($"[{Id}]. {Name} Receive ${money}");
        }
    }
}
