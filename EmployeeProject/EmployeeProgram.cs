using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class EmployeeProgram : MenuProgram
    {
        private List<Employee> employees;
        public EmployeeProgram()
        {
            employees = new List<Employee>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add FullTime");
            System.Console.WriteLine("2. Add PartTime");
            System.Console.WriteLine("3. Add Saler");
            System.Console.WriteLine("4. Display All Employees");
            System.Console.WriteLine("0. Exit");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddFullTime();                         break;
                case 2: AddPartTime();                         break;
                case 3: AddSaler();                            break;
                case 4: DisplayAllEmployees();                 break;
                case 0: Console.WriteLine("Bye!");             break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
        private void AddFullTime()
        {
            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            employees.Add(new FullTime(name, age, rate));
        }
        private void AddPartTime()
        {
            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            employees.Add(new PartTime(name, age, rate, days));
        }
        private void AddSaler()
        {
            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter commission: ");
            double commission = Convert.ToDouble(Console.ReadLine());
            employees.Add(new Saler(name, age, commission));
        }
        private void DisplayAllEmployees()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}