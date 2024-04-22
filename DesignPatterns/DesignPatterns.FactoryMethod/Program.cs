namespace DesignPatterns.FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Credit Card Number:");
            string creditCardNumber = Console.ReadLine() ?? "";
            string bankCode = creditCardNumber.Substring(0, 6);

            IBankFactory bankFactory = new BankFactory();
            IBank? bank = bankFactory.GetBank(bankCode);

            if (bank is null)
                Console.WriteLine("No Banks Found!");
            else
                Console.WriteLine(bank.Withdraw());
        }
    }
}
