namespace DesignPatterns.Proxy
{
    public static class Repository
    {
        public static List<Customer> Customers =
        [
            new Customer()
            {
                Id = 1,
                Username = "ahmed.ali",
                FirstName = "Ahmed",
                LastName = "Ali",
                PhoneNumber = "01234567890",
                MessagesNumber = 2,
            },
            new Customer()
            {
                Id = 1,
                Username = "mohamed.ali",
                FirstName = "Mohamed",
                LastName = "Ali",
                PhoneNumber = "01234567891",
                MessagesNumber = 100,
            },
            new Customer()
            {
                Id = 1,
                Username = "mohamed.ahmed",
                FirstName = "Mohamed",
                LastName = "Ahmed",
                PhoneNumber = "01234567892",
                MessagesNumber = 10,
            },
        ];
    }
}
