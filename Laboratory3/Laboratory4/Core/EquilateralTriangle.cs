namespace Laboratory4.Core;

public class EquilateralTriangle
{
    protected const double TriangleSides = 3;
    protected const double TriangleAnglesTotal = 180.0;

    private double _sideLength;

    public EquilateralTriangle(double sideLength)
    {
        _sideLength = sideLength;
    }

    public void SetSideLength(double sideLength) =>
        _sideLength = sideLength;

    public double GetSide1() =>
        _sideLength;

    public double GetSide2() =>
        _sideLength;

    public double GetSide3() =>
        _sideLength;

    public double GetPerimeter() =>
        TriangleSides * _sideLength;

    public double GetAngle1() =>
        GetAngle();

    public double GetAngle2() =>
        GetAngle();

    public double GetAngle3() =>
        GetAngle();

    public double GetAngle() =>
        TriangleAnglesTotal / TriangleSides;
}