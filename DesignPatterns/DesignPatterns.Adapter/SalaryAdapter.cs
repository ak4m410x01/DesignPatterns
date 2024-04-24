namespace DesignPatterns.Adapter
{
    public class SalaryAdapter : SalaryCalculator
    {
        public decimal CalcSalary(MachineOperator machineOperator)
        {
            return base.CalcSalary(new Employee()
            {
                Name = machineOperator.Name,
                BasicSalary = machineOperator.BasicSalary
            });
        }
    }
}
