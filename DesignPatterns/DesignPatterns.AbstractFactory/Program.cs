namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Credit Card Number:");
            string creditCardNumber = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(creditCardNumber) || creditCardNumber.Length != 12)
            {
                Console.WriteLine("Invalid Credit Card Number");
                return;
            }

            string bankCode = creditCardNumber.Substring(0, 6);

            IBankFactory bankFactory = new BankFactory();
            IBank? bank = bankFactory.GetBank(bankCode);
            IPaymentCard? paymentCard = bankFactory.GetPaymentCard(creditCardNumber);

            if (bank is null)
                Console.WriteLine("No Banks Found!");
            else
                Console.WriteLine(bank.Withdraw());

            if (paymentCard is null)
                Console.WriteLine("No Payment Cards Found!");
            else
            {
                Console.WriteLine(paymentCard.GetName());
                Console.WriteLine(paymentCard.GetProvider());
            }


        }
    }
}
