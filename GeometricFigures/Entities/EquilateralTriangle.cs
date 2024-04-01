namespace GeometricFigures.Entities;

public sealed class EquilateralTriangle : Triangle
{
    private EquilateralTriangle() { }

    public new static EquilateralTriangle Create()
    {
        return new EquilateralTriangle();
    }
    
    public override double CalculateArea()
    {
        var a = Point1.DistanceTo(Point2);

        return Math.Sqrt(3) / 4 * Math.Pow(a, 2);
    }
}