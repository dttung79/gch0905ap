using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student s = new Student();
            // Console.WriteLine("Age = " + s.GetAge());
            // Console.WriteLine("Grade = " + s.Grade);
            // Console.WriteLine("Name = " + s.name);
            
            // s = new Student("", -20, -4.0);
            // Console.WriteLine("Age = " + s.GetAge());
            // Console.WriteLine("Grade = " + s.Grade);
            // Console.WriteLine("Name = " + s.name);

            System.Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter employee salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter employee position: ");
            string position = Console.ReadLine();

            Employee emp = new Employee(name, salary, position);
            emp.ShowInfo();
        }
    }
}
