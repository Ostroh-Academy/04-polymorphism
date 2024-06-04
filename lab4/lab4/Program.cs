using System;

public class Sphere
{
    protected double a, b, c, R;

    public Sphere(double a, double b, double c, double R)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
    }

    public void SetCoefficients(double a, double b, double c, double R)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("R = {0}", R);
    }

    public double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
    }
}

public class Ellipsoid : Sphere
{
    private double b1, b2, b3;

    public Ellipsoid(double a, double b, double c, double R, double b1, double b2, double b3) : base(a, b, c, R)
    {
        this.b1 = b1;
        this.b2 = b2;
        this.b3 = b3;
    }

    // Ми не можемо використовувати override тут, бо методи не є віртуальними
    public new void SetCoefficients(double a, double b, double c, double R)
    {
        base.SetCoefficients(a, b, c, R);
    }

    public new void PrintCoefficients()
    {
        base.PrintCoefficients();
        Console.WriteLine("b1 = {0}", b1);
        Console.WriteLine("b2 = {0}", b2);
        Console.WriteLine("b3 = {0}", b3);
    }

    public new double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * R * b1 * b2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sphere sphere = new Sphere(1, 2, 3, 4);
        Ellipsoid ellipsoid = new Ellipsoid(5, 6, 7, 8, 9, 10, 11);

        sphere.PrintCoefficients();
        double sphereVolume = sphere.GetVolume();
        Console.WriteLine("Sphere Volume: {0}", sphereVolume);

        ellipsoid.PrintCoefficients();
        double ellipsoidVolume = ellipsoid.GetVolume();
        Console.WriteLine("Ellipsoid Volume: {0}", ellipsoidVolume);

        Console.ReadLine();
    }
}
