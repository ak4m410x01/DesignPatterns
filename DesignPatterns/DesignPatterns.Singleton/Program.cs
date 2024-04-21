namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Without Singleton:-");
            WithoutSingleton.Example.Run();
            Console.WriteLine("===============================================");

            Console.WriteLine("With Singleton:-");
            WithSingleton.Example.Run();
            Console.WriteLine("===============================================");


            Console.WriteLine("With MultiThreading:-");
            WithMultiThreading.Example.Run();
            Console.WriteLine("===============================================");

            Console.ReadKey();
        }
    }
}
