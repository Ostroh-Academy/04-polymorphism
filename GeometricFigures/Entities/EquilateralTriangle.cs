namespace GeometricFigures.Entities;

public class EquilateralTriangle : Triangle
{
    public double CalculateArea()
    {
        var a = Point1.DistanceTo(Point2);

        return Math.Sqrt(3) / 4 * Math.Pow(a, 2);
    }
}