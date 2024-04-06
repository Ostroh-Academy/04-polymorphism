namespace _4FORJ;

public abstract class CoordinateSystem
{
    protected internal double radius;
    protected internal double angle;
    protected internal double z;

    public virtual void SetCoordinates(double radius, double angle, double z)
    {
        this.radius = radius;
        this.angle = angle;
        this.z = z;
    }

    public abstract void ConvertToCartesian(out double x, out double y, out double z);
}

public class PolarCoordinateSystem : CoordinateSystem
{
    public override void ConvertToCartesian(out double x, out double y, out double z)
    {
        x = radius * Math.Cos(angle);
        y = radius * Math.Sin(angle);
        z = 0;
    }
}

public class CylindricalCoordinateSystem : CoordinateSystem
{
    public override void ConvertToCartesian(out double x, out double y, out double z)
    {
        x = radius * Math.Cos(angle);
        y = radius * Math.Sin(angle);
        z = this.z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Creating instances of derived classes, but using the base class reference
        CoordinateSystem polarSystem = new PolarCoordinateSystem();
        polarSystem.SetCoordinates(5, Math.PI / 3, 0);

        CoordinateSystem cylindricalSystem = new CylindricalCoordinateSystem();
        cylindricalSystem.SetCoordinates(3, Math.PI / 4, 2);

        // Demonstrating dynamic polymorphism by calling overridden methods using base class reference
        polarSystem.ConvertToCartesian(out var x1, out var y1, out var z1);
        Console.WriteLine($"Polar Coordinates: (radius = {polarSystem.radius}, angle = {polarSystem.angle})");
        Console.WriteLine($"Cartesian Coordinates: (x = {x1}, y = {y1}, z = {z1})");

        cylindricalSystem.ConvertToCartesian(out var x2, out var y2, out var z2);
        Console.WriteLine(
            $"Cylindrical Coordinates: (radius = {cylindricalSystem.radius}, angle = {cylindricalSystem.angle}, z = {cylindricalSystem.z})");
        Console.WriteLine($"Cartesian Coordinates: (x = {x2}, y = {y2}, z = {z2})");
    }
}