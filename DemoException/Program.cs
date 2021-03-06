using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 1;
            try 
            {
                n = Utils.GetInteger("Enter n: ");
                m = Utils.GetInteger("Enter m: ");

                int p = n / m;
                System.Console.WriteLine("{0} / {1} = {2}", n, m, p);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division Error: " + e.Message);
            }
            Console.WriteLine("Program ends.");
        }
    }
}
