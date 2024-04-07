namespace Laba4;

internal class Parallelepiped : Rectangle
{
    private double a3;
    private double b3;

    public Parallelepiped(double a1, double a2, double a3, double b1, double b2, double b3) : base(a1, a2, b1, b2)
    {
        this.a3 = a3;
        this.b3 = b3;
    }

    public override void PrintCoefficients()
    {
        Console.WriteLine($"a1: {a1}, a2: {a2}, a3: {a3}, b1: {b1}, b2: {b2}, b3: {b3}");
    }


    public bool IsPointInside(double x, double y, double z)
    {
        return base.IsPointInside(x, y) && z >= b3 && z <= a3;
    }
}
