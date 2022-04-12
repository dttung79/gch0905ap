using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction Add(Fraction f)
        {
            int a = numerator;
            int b = denominator;
            int c = f.numerator;
            int d = f.denominator;
            Fraction result = new Fraction(a*d + b*c, b*d);
            return result;
        }
    }
}