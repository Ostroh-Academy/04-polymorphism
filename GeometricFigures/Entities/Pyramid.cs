namespace GeometricFigures.Entities;

public class Pyramid : Triangle
{
    protected Point3D Point4 { get; set; } = null!;
    
    protected Pyramid() { }

    public new static Pyramid Create()
    {
        return new Pyramid();
    }

    public void SetCoordinates(Point3D point1, Point3D point2, Point3D point3, Point3D point4)
    {
        Point4 = point4;
        base.SetCoordinates(point1, point2, point3);
    }
    
    public override string PrintCoordinates()
    {
        return $"Coordinates of the pyramid: " +
               $"({Point1.X},{Point1.Y},{Point1.Z}), " +
               $"({Point2.X},{Point2.Y},{Point2.Z}), " +
               $"({Point3.X},{Point3.Y},{Point3.Z}), " +
               $"({Point4.X},{Point4.Y},{Point4.Z})";
    }

    public override double CalculateArea()
    {
        var baseArea = base.CalculateArea();
        
        var height = CalculateHeight();
        var area = (baseArea * height) / 3;

        return area;
    }

    private double CalculateHeight()
    {
        var baseCenter = CalculateBaseCenter();
        var height = Point4.DistanceTo(baseCenter);

        return height;
    }
    
    private Point3D CalculateBaseCenter()
    {
        var centerX = (Point1.X + Point2.X + Point3.X) / 3;
        var centerY = (Point1.Y + Point2.Y + Point3.Y) / 3;
        var centerZ = (Point1.Z + Point2.Z + Point3.Z) / 3;

        return new Point3D(centerX, centerY, centerZ);
    }
}