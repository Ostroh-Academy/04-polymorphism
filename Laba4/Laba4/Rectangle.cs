using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4;

internal class Rectangle
{
    protected double a1;
    protected double a2;
    protected double b1;
    protected double b2;

    public Rectangle(double a1, double a2, double b1, double b2)
    {
        this.a1 = a1;
        this.a2 = a2;
        this.b1 = b1;
        this.b2 = b2;
    }

    public virtual void PrintCoefficients()
    {
        Console.WriteLine($"a1: {a1}, a2: {a2}, b1: {b1}, b2: {b2}");
    }

    public bool IsPointInsideByTwoCoordinates(double x, double y)
    {
        return (x >= b1 && x <= a1 && y >= b2 && y <= a2);
    }
}
