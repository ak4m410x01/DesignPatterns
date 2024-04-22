namespace DesignPatterns.FactoryMethod
{
    public interface IBankFactory
    {
        IBank? GetBank(string bankCode);
    }
}
