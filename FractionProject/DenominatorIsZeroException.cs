using System;

namespace FractionProject
{
    public class DenominatorIsZeroException : Exception
    {
        public DenominatorIsZeroException()
        {
        }
        public DenominatorIsZeroException(string msg) : base(msg)
        {
        }
    }
}