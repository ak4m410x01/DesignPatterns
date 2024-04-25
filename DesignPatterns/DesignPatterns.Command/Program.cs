namespace DesignPatterns.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new();

            Console.WriteLine("First Senario (Only One Receiver)....\n");
            Receiver receiver = new("100", "Abdullah");


            SendMoneyCommand command = new(receiver);
            invoker.Invoke(command);

            Console.WriteLine("\n--------------------------------------\n");

            Console.WriteLine("Second Senario (Multiple Receivers)....\n");
            IEnumerable<Receiver> receivers = [
                new("1", "Mohamed"),
                new("2", "Ahmed"),
                new("3", "Ali")
              ];

            SendMoneyToAllCommand moneyToAllCommand = new(receivers);
            invoker.Invoke(moneyToAllCommand);

        }
    }
}
