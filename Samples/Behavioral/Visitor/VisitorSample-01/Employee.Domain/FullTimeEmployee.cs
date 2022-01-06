using System;
using Employee.Domain.SalaryCalculatorVisitor;

namespace Employee.Domain
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(long salary, long tax)
        {
            this.Salary = salary;
            this.Tax = tax;
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}