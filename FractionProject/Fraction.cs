using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class Fraction
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            { 
                if (value == 0) throw new DenominatorIsZeroException("Denominator cannot be 0");
                else            denominator = value;
            }            
        }
        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }
        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }
        public Fraction Add(Fraction f)
        {
            int a = numerator;
            int b = denominator;
            int c = f.numerator;
            int d = f.denominator;
            Fraction result = new Fraction(a*d + b*c, b*d);
            return result;
        }
        public Fraction Div(Fraction f)
        {
            int a = numerator;
            int b = denominator;
            int c = f.numerator;
            int d = f.denominator;
            Fraction result = new Fraction(a*d, b*c);
            return result;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", Numerator, Denominator);
        }
    }
}