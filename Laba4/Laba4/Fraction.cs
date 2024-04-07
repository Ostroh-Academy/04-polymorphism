using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Fraction
    {
        protected double a;

        public Fraction(double coefficient)
        {
            a = coefficient;
        }

        public virtual void SetCoefficient(double coefficient)
        {
            a = coefficient;
        }

        public virtual void PrintCoefficient()
        {
            Console.WriteLine("Coefficient a: " + a);
        }

        public virtual double CalculateFractionValue(double x)
        {
            return 1 / (a * x);
        }
    }
}
