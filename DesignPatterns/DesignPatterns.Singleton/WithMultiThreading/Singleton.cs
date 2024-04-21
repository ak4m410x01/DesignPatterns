namespace DesignPatterns.Singleton.WithMultiThreading
{
    // => Using Null Checking
    //public sealed class Singleton
    //{
    //    private Singleton()
    //    {
    //    }

    //    private static readonly object _lock = new();

    //    private static Singleton? _instance = null;
    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            if (_instance is null)
    //            {
    //                lock (_lock)
    //                {
    //                    if (_instance is null)
    //                        _instance = new Singleton();
    //                }
    //            }
    //            return _instance;
    //        }
    //    }
    //}

    // => Using Lazy<T>
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        private static Lazy<Singleton> _instance = new(() => new Singleton());
        public static Singleton Instance => _instance.Value;
    }
}
