using System;

namespace FractionProject
{
    public class Utils
    {
        public static int GetInteger(string prompt)
        {
            int n = 0;
            while (true)
            {
                try 
                {
                    System.Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }
            return n;
        }

        public static Fraction GetFraction(string prompt)
        {
            int a = GetInteger("Enter numerator: ");
            int b = 0;
            while (b == 0)
            {
                b = GetInteger("Enter denominator: ");
                if (b == 0)
                {
                    Console.WriteLine("Denominator cannot be 0. Try again.");
                }
            }
            return new Fraction(a, b);

        }
        public static Fraction GetFraction2()
        {
            Fraction f = new Fraction();
            int a = GetInteger("Enter numerator: ");
            while (true)
            {
                try 
                {                    
                    int b = GetInteger("Enter denominator: ");
                    f = new Fraction(a, b);
                    break;
                } catch (DenominatorIsZeroException)
                {
                    Console.WriteLine("Denominator cannot be 0. Try again.");
                }
            }
            return f;
        }
    }
}