namespace DesignPatterns.Proxy
{
    public class SMSServiceProxy
    {
        public SMSServiceProxy(ISMSService smsService)
        {
            _smsService = smsService;
        }
        private readonly ISMSService _smsService;

        public bool Send(int customerId, string phoneNumber, string message)
        {
            Customer? customer = Repository.Customers.Find(c => c.Id == customerId);
            if ((customer is null) || (customer.MessagesNumber == 0))
                return false;

            bool isSent = _smsService.Send(phoneNumber, message);
            if (!isSent)
                return false;

            customer.MessagesNumber -= 1;
            return true;
        }
    }
}
