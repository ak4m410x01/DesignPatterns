namespace DesignPatterns.Singleton.WithoutSingleton
{
    public static class Example
    {
        public static void Run()
        {
            Singleton singleton1 = new();
            Singleton singleton2 = new();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Objects has the same instance.");
            }
            else
            {
                Console.WriteLine("Object not has the same instance.");
            }
        }
    }
}
