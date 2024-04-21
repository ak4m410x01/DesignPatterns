namespace DesignPatterns.Prototype
{
    public class Address
    {
        public string Building { get; set; } = default!;
        public string StreetName { get; set; } = default!;
        public string City { get; set; } = default!;

        public override string ToString()
        {
            return $"{City},{StreetName},{Building}";
        }
    }
}
