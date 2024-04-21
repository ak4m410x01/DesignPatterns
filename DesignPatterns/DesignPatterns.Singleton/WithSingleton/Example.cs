namespace DesignPatterns.Singleton.WithSingleton
{
    public static class Example
    {
        public static void Run()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

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
