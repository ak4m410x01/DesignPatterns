namespace DesignPatterns.Singleton.WithMultiThreading
{
    public static class Example
    {
        public static void Run()
        {
            Singleton? singleton1 = default;
            Singleton? singleton2 = default;

            Task task1 = Task.Factory.StartNew(() =>
            {
                singleton1 = Singleton.Instance;
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                singleton2 = Singleton.Instance;
            });

            Task.WaitAll(task1, task2);

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
