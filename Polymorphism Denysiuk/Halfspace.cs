using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Denysiuk
{
    public class Halfspace : Halfplane
    {
        private double a3;

        public void SetCoefficients(double a1, double a2, double a3, double b)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.b = b;
        }

        public void DisplayCoefficients()
        {
            Console.WriteLine($"Коефiцiєнти пiвпростору: a1 = {a1}, a2 = {a2}, a3 = {a3}, b = {b}");
        }

        public override bool IsPointInHalfplane(double x1, double x2)
        {
            return (a1 * x1 + a2 * x2 + a3 <= b);
        }
    }
}
