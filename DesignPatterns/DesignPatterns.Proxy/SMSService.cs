namespace DesignPatterns.Proxy
{
    public class SMSService : ISMSService
    {
        public bool Send(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending... '{message}' to {phoneNumber} from.");
            return true;
        }
    }
}
