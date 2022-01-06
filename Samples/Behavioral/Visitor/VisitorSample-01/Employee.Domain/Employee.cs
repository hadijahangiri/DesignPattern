using Employee.Domain.SalaryCalculatorVisitor;

namespace Employee.Domain
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public long Salary { get; set; }
        public long Tax { get; set; }

        public abstract void AcceptVisitor(IVisitor visitor);
    }
}
