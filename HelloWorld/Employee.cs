using System;

namespace HelloWorld
{
    public class Employee
    {
        // TODO: name, salary, position
        private string name;
        private int salary;         // 500 <= salaraly <= 5000
        private string position;    // Staff, Leader, CEO
        public string Name
        {
            get { return name; }
            set 
            {
                if (value == "") 
                {
                    System.Console.WriteLine("Invalid name!");
                    name = "No name";
                }
                else name = value;
            }
        }
        // Requirement: write properties, validate input, default constructor
        public int Salary 
        {
            get { return salary; }
            set 
            {
                if (value < 500 || value > 5000)
                {
                    System.Console.WriteLine("Invalid salary!");
                    salary = 500;
                }
                else salary = value;
            }
        }
        public string Position
        {
            get { return position; }
            set 
            {
                if (value != "Staff" && value != "Leader" && value != "CEO")
                {
                    System.Console.WriteLine("Invalid position!");
                    position = "Staff";
                }
                else position = value;
            }
        }
        // default constructor
        public Employee()
        {
            name = "New Employee";
            position = "Staff";
            salary = 500;
        }

        public Employee(string name, int salary, string position)
        {
            Name = name;
            Salary = salary;
            Position = position;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Employee name: " + name);
            System.Console.WriteLine("Employee salary: " + salary);
            System.Console.WriteLine("Employee position: " + position);
        }
    }
}