using System;

namespace DemoInterface
{
    public class Line : Shape
    {
        public int Length { get; set; }
        public Line() : base("Line")
        {
            Length = 1;
        }
        public Line(string name, int length) : base(name)
        {
            Length = length;
        }

        public override void Print()
        {
            base.Print();
            for (int i = 0; i < Length; i++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}