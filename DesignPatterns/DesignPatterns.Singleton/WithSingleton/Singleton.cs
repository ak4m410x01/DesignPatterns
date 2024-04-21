namespace DesignPatterns.Singleton.WithSingleton
{
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton? _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new Singleton();
                return _instance;
            }
        }
    }
}
