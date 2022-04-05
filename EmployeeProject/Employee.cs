using System;


namespace EmployeeProject
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public const double BASIC_SALARY = 1000;

        public Employee()
        {
            Name = "Employee";
            Age = 18;
        }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract double Salary();

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Salary: " + Salary();
        }
    }
}