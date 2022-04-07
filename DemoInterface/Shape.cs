using System;

namespace DemoInterface
{
    public class Shape : IPrintable
    {
        public string Name { get; set; }
        public Shape()
        {
            Name = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
        }
        
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }

}