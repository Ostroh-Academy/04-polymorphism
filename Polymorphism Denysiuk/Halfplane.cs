using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Denysiuk
{
    public class Halfplane
    {
        protected double a1, a2, b;

        public void SetCoefficients(double a1, double a2, double b)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b = b;
        }

        public void DisplayCoefficients()
        {
            Console.WriteLine($"Коефiцiєнти пiвплощини: a1 = {a1}, a2 = {a2}, b = {b}");
        }

        public virtual bool IsPointInHalfplane(double x1, double x2)
        {
            return (a1 * x1 + a2 * x2 <= b);
        }
    }
}
