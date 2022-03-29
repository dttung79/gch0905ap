using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Pet : Animal
    {
        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Pet() : base("Pet", 1)
        {
            // Kind = "Pet";
            // Age = 1;
            owner = "Human";
            System.Console.WriteLine("Pet default constructor");
        }

        public Pet(string kind, int age, string owner) : base(kind, age)
        {
            // Kind = kind;
            // Age = age;
            Owner = owner;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Pet kind: " + Kind);
            System.Console.WriteLine("Pet age: " + Age);
            System.Console.WriteLine("Pet owner: " + owner);
        }
    }
}