namespace DesignPatterns.Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new();
            IProductBuilder carBuilder = new Car("Jeep");
            IProductBuilder motorCycleBuilder = new MotorCycle("Honda");

            // Making Car
            Console.WriteLine("Making Car...\n");
            director.Construct(carBuilder);
            Product car = carBuilder.GetProduct();
            Console.WriteLine(car.GetResult());

            Console.WriteLine("\n--------------------------------------\n");
            // Making MotorCycle
            Console.WriteLine("Making MotorCycle...\n");
            director.Construct(motorCycleBuilder);
            Product motorCycle = motorCycleBuilder.GetProduct();
            Console.WriteLine(motorCycle.GetResult());
        }
    }
}
