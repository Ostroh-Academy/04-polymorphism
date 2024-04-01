namespace GeometricFigures.Entities;

public class Triangle 
{
    protected Point3D Point1 { get; private set; } = null!;
    protected Point3D Point2 { get; private set; } = null!;
    protected Point3D Point3 { get; private set; } = null!;

    public void SetCoordinates(Point3D point1, Point3D point2, Point3D point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    public virtual string PrintCoordinates()
    {
        return $"Coordinates of the triangle: " +
               $"({Point1.X},{Point1.Y},{Point1.Z}), " +
               $"({Point2.X},{Point2.Y},{Point2.Z}), " +
               $"({Point3.X},{Point3.Y},{Point3.Z})";
    }

    public virtual double CalculateArea()
    {
        var a = Point1.DistanceTo(Point2);
        var b = Point2.DistanceTo(Point3);
        var c = Point3.DistanceTo(Point1);

        var s = (a + b + c) / 2;

        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}