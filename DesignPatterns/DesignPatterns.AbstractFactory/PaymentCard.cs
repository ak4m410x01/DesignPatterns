namespace DesignPatterns.AbstractFactory
{
    public class PaymentCard : IPaymentCard
    {
        public virtual string GetName()
        {
            return $"Default Payment Card";
        }

        public virtual string GetProvider()
        {
            return $"Default Payment Card Provider";
        }
    }
}
