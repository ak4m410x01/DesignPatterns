namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        public Approver Successor { get; set; }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
