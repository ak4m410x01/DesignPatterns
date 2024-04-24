namespace DesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.Successor = sam;
            sam.Successor = tammy;

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 12590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project Y");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Z");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
