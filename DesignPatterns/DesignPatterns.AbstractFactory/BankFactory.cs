namespace DesignPatterns.AbstractFactory
{
    public class BankFactory : IBankFactory
    {
        public virtual IBank? GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "111111":
                    return new BankA();

                case "222222":
                    return new BankB();

                default:
                    return null;
            }
        }

        public IPaymentCard? GetPaymentCard(string cardCode)
        {
            switch (cardCode[0])
            {
                case '1':
                    return new Visa();

                case '2':
                    return new MasterCard();

                default:
                    return null;
            }
        }
    }
}
