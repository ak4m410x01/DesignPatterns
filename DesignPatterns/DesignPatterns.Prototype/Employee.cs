namespace DesignPatterns.Prototype
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public abstract Employee ShallowCopy();
        public abstract Employee DeepCopy();

        public override string ToString()
        {
            return $"{Id},{Name},{Address}";
        }
    }
}
