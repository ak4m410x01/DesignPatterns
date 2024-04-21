namespace DesignPatterns.Builder
{
    public interface IProductBuilder
    {
        void StartOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLights();
        void EndOperations();

        Product GetProduct();
    }
}
