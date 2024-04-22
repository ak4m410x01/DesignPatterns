namespace DesignPatterns.AbstractFactory
{
    public class BankA : Bank
    {
        public override string Withdraw()
        {
            return $"The Request handling by BankA.";
        }
    }
}
