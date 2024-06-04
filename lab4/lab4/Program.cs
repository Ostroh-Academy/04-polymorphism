using System;

public abstract class Shape
{
    protected double a, b, c, R;

    public Shape(double a, double b, double c, double R)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
    }

    public virtual void SetCoefficients(double a, double b, double c, double R)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
    }

    public virtual void PrintCoefficients()
    {
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("R = {0}", R);
    }

    public abstract double GetVolume();
}

public class Sphere : Shape
{
    public Sphere(double a, double b, double c, double R) : base(a, b, c, R) { }

    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
    }
}

public class Ellipsoid : Shape
{
    private double b1, b2, b3;

    public Ellipsoid(double a, double b, double c, double R, double b1, double b2, double b3) : base(a, b, c, R)
    {
        this.b1 = b1;
        this.b2 = b2;
        this.b3 = b3;
    }

    public override void SetCoefficients(double a, double b, double c, double R)
    {
        base.SetCoefficients(a, b, c, R);
    }

    public override void PrintCoefficients()
    {
        base.PrintCoefficients();
        Console.WriteLine("b1 = {0}", b1);
        Console.WriteLine("b2 = {0}", b2);
        Console.WriteLine("b3 = {0}", b3);
    }

    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * R * b1 * b2;
    }
}

public abstract class ShapeFactory
{
    public abstract Shape CreateShape();
}

public class SphereFactory : ShapeFactory
{
    private double a, b, c, R;

    public SphereFactory(double a, double b, double c, double R)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
    }

    public override Shape CreateShape()
    {
        return new Sphere(a, b, c, R);
    }
}

public class EllipsoidFactory : ShapeFactory
{
    private double a, b, c, R, b1, b2, b3;

    public EllipsoidFactory(double a, double b, double c, double R, double b1, double b2, double b3)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.R = R;
        this.b1 = b1;
        this.b2 = b2;
        this.b3 = b3;
    }

    public override Shape CreateShape()
    {
        return new Ellipsoid(a, b, c, R, b1, b2, b3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory sphereFactory = new SphereFactory(1, 2, 3, 4);
        Shape sphere = sphereFactory.CreateShape();
        sphere.PrintCoefficients();
        double sphereVolume = sphere.GetVolume();
        Console.WriteLine("Sphere Volume: {0}", sphereVolume);

        ShapeFactory ellipsoidFactory = new EllipsoidFactory(5, 6, 7, 8, 9, 10, 11);
        Shape ellipsoid = ellipsoidFactory.CreateShape();
        ellipsoid.PrintCoefficients();
        double ellipsoidVolume = ellipsoid.GetVolume();
        Console.WriteLine("Ellipsoid Volume: {0}", ellipsoidVolume);

        Console.ReadLine();
    }
}
