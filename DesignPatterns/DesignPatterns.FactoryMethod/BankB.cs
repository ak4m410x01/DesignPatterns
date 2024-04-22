namespace DesignPatterns.FactoryMethod
{
    public class BankB : Bank
    {
        public override string Withdraw()
        {
            return $"The Request handling by BankB.";
        }
    }
}
