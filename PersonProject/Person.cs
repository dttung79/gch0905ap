using System;

namespace PersonProject
{
    public class Person
    {
        protected string name;
        protected int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            name = "John Doe";
            age = 1;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
        }
    }
}