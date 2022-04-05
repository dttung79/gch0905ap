using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Saler : Employee
    {
        public int Products { get; set; }
        public double Commission { get; set; }

        public Saler() : base()
        {
            Products = 0;
            Commission = 0.01;
        }

        public Saler(string name, int age, double commission) : base(name, age)
        {
            Products = 0;
            Commission = commission;
        }
        public void SaleProducts()
        {
            System.Console.Write("How many products did you sell? ");
            Products = Convert.ToInt32(System.Console.ReadLine());
        }

        public override double Salary()
        {
            SaleProducts();
            return Products * Commission + BASIC_SALARY * Commission;
        }
    }
}