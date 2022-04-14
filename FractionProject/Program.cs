using System;

namespace FractionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = Utils.GetInteger("Enter a: ");
            // int b = Utils.GetInteger("Enter b: ");
            // int c = Utils.GetInteger("Enter c: ");
            // int d = Utils.GetInteger("Enter d: ");

            // Fraction f1 = new Fraction(a, b);
            // Fraction f2 = new Fraction(c, d);
            Fraction f1 = Utils.GetFraction("Enter fraction 1: ");
            Fraction f2 = Utils.GetFraction("Enter fraction 2: ");
            Console.WriteLine(String.Format("{0} + {1} = {2}", f1, f2, f1.Add(f2)));
            Console.WriteLine(String.Format("{0} / {1} = {2}", f1, f2, f1.Div(f2)));

        }
    }
}
