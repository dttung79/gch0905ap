using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Animal
    {
        protected string kind;
        protected int age;

        public string Kind 
        {
            get { return kind; }
            set { kind = value; }
        }

        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public Animal()
        {
            kind = "Animal";
            age = 0;
            System.Console.WriteLine("Animal default constructor");
        }

        public Animal(string kind, int age)
        {
            Kind = kind;
            Age = age;
            System.Console.WriteLine("Animal parameter constructor");
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Animal kind: " + kind);
            System.Console.WriteLine("Animal age: " + age);
        }
    }
}