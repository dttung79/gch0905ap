using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new FullTime("John", 20, 1.0);
            System.Console.WriteLine(emp);

            emp = new PartTime("Mary", 18, 1.0, 2);
            System.Console.WriteLine(emp);

            emp = new Saler("Tom", 20, 0.05);
            System.Console.WriteLine(emp);
        }
    }
}
