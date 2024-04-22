namespace DesignPatterns.AbstractFactory
{
    public class MasterCard : PaymentCard
    {
        public override string GetName()
        {
            return $"Default MasterCard Payment Card";
        }
        public override string GetProvider()
        {
            return $"Default MasterCard Payment Card Provider";
        }
    }
}
