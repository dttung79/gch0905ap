using System;

namespace DemoInterface
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square() : base("Square")
        {
            Side = 1;
        }
        public Square(string name, int side) : base(name)
        {
            Side = side;
        }
        public override void Print()
        {
            base.Print();
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}