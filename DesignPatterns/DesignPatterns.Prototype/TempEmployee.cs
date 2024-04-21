namespace DesignPatterns.Prototype
{
    public class TempEmployee : Employee
    {
        public override Employee DeepCopy()
        {
            TempEmployee employee = (TempEmployee)ShallowCopy();

            // Copy Reference Type manually
            employee.Name = Name;
            employee.Address = new Address()
            {
                City = Address.City,
                StreetName = Address.StreetName,
                Building = Address.Building,
            };

            return employee;
        }

        public override Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}
