namespace DesignPatterns.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularEmployee employee1 = new RegularEmployee()
            {
                Id = 1,
                Name = "Employee 1",
                Address = new Address() { City = "Sohag", StreetName = "15 st", Building = "3B" }
            };


            // Shallow Copy:-
            //    - Value Type: Create new object
            //    - Reference Type: Take the same instance

            // Deep Copy:-
            //    - Value Type: Create new object
            //    - Reference Type: Create new object


            Console.WriteLine("Hash Codes:-\n\n");

            Console.WriteLine($"   - Original Object     : {employee1.GetHashCode()}");
            Console.WriteLine($"   - Object Shallow Copy : {employee1.ShallowCopy().GetHashCode()}");
            Console.WriteLine($"   - Object Deep Copy    : {employee1.DeepCopy().GetHashCode()}");

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine($"   - Original Object Value Type Id     : {employee1.Id.GetHashCode()}");
            Console.WriteLine($"   - Object Value Type Id Shallow Copy : {employee1.ShallowCopy().Id.GetHashCode()}");
            Console.WriteLine($"   - Object Value Type Id Deep Copy    : {employee1.DeepCopy().Id.GetHashCode()}");

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine($"   - Original Object Reference Type Address     : {employee1.Address.GetHashCode()}");
            Console.WriteLine($"   - Object Reference Type Address Shallow Copy : {employee1.ShallowCopy().Address.GetHashCode()}");
            Console.WriteLine($"   - Object Reference Type Address Deep Copy    : {employee1.DeepCopy().Address.GetHashCode()}");

            Console.WriteLine("\n---------------------------------------------------\n");
        }
    }
}
