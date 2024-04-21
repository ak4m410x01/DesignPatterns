namespace DesignPatterns.Singleton.WithSingleton
{
    public static class Example
    {
        public static void Run()
        {
            Counter counter1 = Counter.Instance;
            Counter counter2 = Counter.Instance;

            counter1.AddCount();
            counter2.AddCount();

            Console.WriteLine($"Counter1: {counter1.Count}");
            Console.WriteLine($"Counter2: {counter2.Count}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            counter1.AddCount();

            Console.WriteLine($"Counter1: {counter1.Count}");
            Console.WriteLine($"Counter2: {counter2.Count}");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
