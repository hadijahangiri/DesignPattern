using System;
using System.Collections.Generic;
using Employee.Domain.SalaryCalculatorVisitor;
using Xunit;

namespace Employee.Domain.Tests
{
    public class SalaryCalculatorVisitorTests
    {
        [Fact]
        public void Calculate_salary()
        {
            var sumPayedSalary = 1800;
            var employees = new List<Employee>
            {
                new FullTimeEmployee(1000, 100),
                new PartTimeEmployee(900)
            };

            var salaryCalculatorVisitorService = new SalaryCalculatorVisitorService();
            employees.ForEach(a=>a.AcceptVisitor(salaryCalculatorVisitorService));

            Assert.Equal(salaryCalculatorVisitorService.CalculateSalary(), sumPayedSalary);
        }
    }
}
