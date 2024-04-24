namespace DesignPatterns.Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee01 = new() { Name = "Employee_01", BasicSalary = 1000 };
            SalaryCalculator salaryCalculator = new();
            decimal employee01_salary = salaryCalculator.CalcSalary(employee01);
            Console.WriteLine($"Employee01: Name={employee01.Name}, Salary={employee01_salary}");

            MachineOperator machineOperator01 = new() { Name = "MachineOperator_01", BasicSalary = 10000 };
            SalaryAdapter salaryAdapter = new();
            decimal machineOperator01_salary = salaryAdapter.CalcSalary(new Employee()
            {
                Name = machineOperator01.Name,
                BasicSalary = machineOperator01.BasicSalary
            });
            Console.WriteLine($"MachineOperator01: Name={machineOperator01.Name}, Salary={machineOperator01_salary}");


        }
    }
}
