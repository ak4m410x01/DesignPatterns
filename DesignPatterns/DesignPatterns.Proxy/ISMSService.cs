namespace DesignPatterns.Proxy
{
    public interface ISMSService
    {
        bool Send(string phoneNumber, string message);
    }
}
