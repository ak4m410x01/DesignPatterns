namespace DesignPatterns.Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            SMSServiceProxy smsServiceProxy = new(new SMSService());

            bool message1Status = smsServiceProxy.Send(1, "01234567891", "Hello, ...");
            Console.WriteLine($"Message 1 Status = {message1Status}");

            Console.WriteLine("\n---------------------------------\n");

            bool message2Status = smsServiceProxy.Send(1, "01234567891", "Hello, ...");
            Console.WriteLine($"Message 1 Status = {message2Status}");

            Console.WriteLine("\n---------------------------------\n");

            bool message3Status = smsServiceProxy.Send(1, "01234567891", "Hello, ...");
            Console.WriteLine($"Message 1 Status = {message3Status}");
        }
    }
}
