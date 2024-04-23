namespace DesignPatterns.Proxy
{
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; } = default!;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = default!;
        public int MessagesNumber { get; set; }
    }
}
