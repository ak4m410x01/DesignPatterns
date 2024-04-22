namespace DesignPatterns.FactoryMethod
{
    public class BankA : Bank
    {
        public override string Withdraw()
        {
            return $"The Request handling by BankA.";
        }
    }
}
