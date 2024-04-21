namespace DesignPatterns.Builder
{
    public class MotorCycle : IProductBuilder
    {
        public MotorCycle(string brand)
        {
            _brand = brand;
            _product = new Product();
        }

        private readonly string _brand;
        private readonly Product _product;

        public void StartOperations()
        {
            _product.Add($"MotorCycle Brand Name: {_brand}");
        }

        public void BuildBody()
        {
            _product.Add("MotorCycle Body");
        }
        public void InsertWheels()
        {
            _product.Add("MotorCycle Wheels");
        }
        public void AddHeadLights()
        {
            _product.Add("MotorCycle HeadLights");
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
