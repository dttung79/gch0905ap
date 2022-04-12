using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoException
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
    }
}