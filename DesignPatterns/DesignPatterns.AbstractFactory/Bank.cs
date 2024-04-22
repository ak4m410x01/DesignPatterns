namespace DesignPatterns.AbstractFactory
{
    public class Bank : IBank
    {
        public virtual string Withdraw()
        {
            return "The Request is handling by Base Bank.";
        }
    }
}
