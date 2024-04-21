namespace DesignPatterns.Builder
{
    public class Car : IProductBuilder
    {
        public Car(string brand)
        {
            _brand = brand;
            _product = new Product();
        }

        private readonly string _brand;
        private readonly Product _product;

        public void StartOperations()
        {
            _product.Add($"Car Brand Name: {_brand}");
        }

        public void BuildBody()
        {
            _product.Add("Car Body");
        }
        public void InsertWheels()
        {
            _product.Add("Car Wheels");
        }
        public void AddHeadLights()
        {
            _product.Add("Car HeadLights");
        }

        public void EndOperations()
        {
            // End Operations
        }


        public Product GetProduct()
        {
            return _product;
        }
    }
}
