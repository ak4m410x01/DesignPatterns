namespace DesignPatterns.FactoryMethod
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
    }
}
