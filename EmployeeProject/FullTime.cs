using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class FullTime : Employee
    {
        public double Rate { get; set; }
        public FullTime() : base()
        {
            Rate = 1.0;
        }
        public FullTime(string name, int age, double rate) : base(name, age)
        {
            Rate = rate;
        }

        public override double Salary()
        {
            return Rate * BASIC_SALARY;
        }
    }
}