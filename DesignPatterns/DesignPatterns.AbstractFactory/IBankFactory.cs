namespace DesignPatterns.AbstractFactory
{
    public interface IBankFactory
    {
        IBank? GetBank(string bankCode);
        IPaymentCard? GetPaymentCard(string cardCode);
    }
}
