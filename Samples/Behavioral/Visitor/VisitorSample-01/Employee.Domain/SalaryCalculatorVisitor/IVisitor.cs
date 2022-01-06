using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.SalaryCalculatorVisitor
{
    public interface IVisitor //domain service
    {
        void Accept(PartTimeEmployee partTimeEmployee);
        void Accept(FullTimeEmployee fullTimeEmployee);
    }
}
