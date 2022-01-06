namespace Employee.Domain.SalaryCalculatorVisitor
{
    public class SalaryCalculatorVisitorService : IVisitor
    {
        private long _salary = 0;
        public void Accept(PartTimeEmployee partTimeEmployee)
        {
            _salary += partTimeEmployee.Salary;
        }

        public void Accept(FullTimeEmployee fullTimeEmployee)
        {
            _salary += fullTimeEmployee.Salary - fullTimeEmployee.Tax;
        }

        public long CalculateSalary() => _salary;
    }
}