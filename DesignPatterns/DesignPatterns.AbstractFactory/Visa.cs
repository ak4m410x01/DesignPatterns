namespace DesignPatterns.AbstractFactory
{
    public class Visa : PaymentCard
    {
        public override string GetName()
        {
            return $"Default Visa Payment Card";
        }
        public override string GetProvider()
        {
            return $"Default Visa Payment Card Provider";
        }
    }
}
