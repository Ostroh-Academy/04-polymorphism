namespace GeometricFigures.Entities;

public class Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }


    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public double DistanceTo(Point3D otherPoint)
    {
        var dx = X - otherPoint.X;
        var dy = Y - otherPoint.Y;
        var dz = Z - otherPoint.Z;
        
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}