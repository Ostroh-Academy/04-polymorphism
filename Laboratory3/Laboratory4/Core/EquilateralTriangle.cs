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

    public virtual double GetSide2() =>
        _sideLength;

    public virtual double GetSide3() =>
        _sideLength;

    public virtual double GetPerimeter() =>
        TriangleSides * _sideLength;

    public virtual double GetAngle1() =>
        GetAngle();

    public virtual double GetAngle2() =>
        GetAngle();

    public virtual double GetAngle3() =>
        GetAngle();

    public virtual double GetAngle() =>
        TriangleAnglesTotal / TriangleSides;
}