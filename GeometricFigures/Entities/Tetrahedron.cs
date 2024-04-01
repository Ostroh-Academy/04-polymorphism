namespace GeometricFigures.Entities;

public sealed class Tetrahedron : Pyramid
{
    public override string PrintCoordinates()
    {
        return $"Coordinates of the tetrahedron: " +
               $"({Point1.X},{Point1.Y},{Point1.Z}), " +
               $"({Point2.X},{Point2.Y},{Point2.Z}), " +
               $"({Point3.X},{Point3.Y},{Point3.Z}), " +
               $"({Point4.X},{Point4.Y},{Point4.Z})";
    }
    
    public override double CalculateArea()
    {
        var a = Point1.DistanceTo(Point2);
        var b = Point2.DistanceTo(Point3);
        var c = Point3.DistanceTo(Point1);
        var d = Point1.DistanceTo(Point4);
        var e = Point2.DistanceTo(Point4);
        var f = Point3.DistanceTo(Point4);

        var s1 = (a + b + d) / 2;
        var s2 = (b + c + e) / 2;
        var s3 = (c + a + f) / 2;
        var s4 = (d + e + f) / 2;

        var volume = Math.Sqrt(s1 * (s1 - a) * (s1 - b) * (s1 - d)) +
                     Math.Sqrt(s2 * (s2 - b) * (s2 - c) * (s2 - e)) +
                     Math.Sqrt(s3 * (s3 - c) * (s3 - a) * (s3 - f)) +
                     Math.Sqrt(s4 * (s4 - d) * (s4 - e) * (s4 - f));

        return volume;
    }
}