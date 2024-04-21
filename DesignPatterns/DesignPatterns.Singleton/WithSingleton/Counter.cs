namespace DesignPatterns.Singleton.WithSingleton
{
    public class Counter
    {
        private Counter()
        {
        }

        private static Counter? _instance = null;
        public static Counter Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new Counter();
                return _instance;
            }
        }

        public int Count { get; set; }


        public void AddCount()
        {
            Count++;
        }
    }
}
