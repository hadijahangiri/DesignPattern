using System;
using Employee.Domain.SalaryCalculatorVisitor;

namespace Employee.Domain
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(long salary)
        {
            this.Salary = salary;
            this.Tax = 0;
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}