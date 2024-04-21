namespace DesignPatterns.Singleton.WithoutSingleton
{
    public static class Example
    {
        public static void Run()
        {
            Counter counter1 = new();
            Counter counter2 = new();

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
