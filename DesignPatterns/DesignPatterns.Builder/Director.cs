namespace DesignPatterns.Builder
{
    public class Director
    {
        public void Construct(IProductBuilder builder)
        {
            _builder = builder;

            // Start Object Building
            builder.StartOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOperations();
            // End Object Building
        }

        private IProductBuilder? _builder;
    }
}
