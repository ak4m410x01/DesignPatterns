namespace DesignPatterns.Adapter
{
    public class SalaryCalculator
    {
        public virtual decimal CalcSalary(Employee employee) => employee.BasicSalary * 1.5m;
    }
}
