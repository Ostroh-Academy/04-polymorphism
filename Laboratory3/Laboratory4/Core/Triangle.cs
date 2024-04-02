using ArgumentException = System.ArgumentException;

namespace Laboratory4.Core;

public class Triangle : EquilateralTriangle
{
    private double _angle1;
    private double _angle2;

    public Triangle(double sideLength, double angle1, double angle2)
        : base(sideLength)
    {
        if(angle1 + angle2 >= TriangleAnglesTotal)
            throw new ArgumentException($"Invalid angles: sum must be less than {TriangleAnglesTotal} degrees.");

        _angle1 = angle1;
        _angle2 = angle2;
    }

    public void SetAngles(double angle1, double angle2)
    {
        if(angle1 + angle2 >= TriangleAnglesTotal)
            throw new ArgumentException($"Invalid angles: sum must be less than {TriangleAnglesTotal} degrees.");

        _angle1 = angle1;
        _angle2 = angle2;
    }

    public new double GetAngle1() =>
        _angle1;

    public new double GetAngle2() =>
        _angle2;

    public new double GetAngle3() =>
        TriangleAnglesTotal - _angle1 - _angle2;

    public new double GetSide2() =>
        base.GetSide2() * Math.Sin(_angle1 * Math.PI / TriangleAnglesTotal) / Math.Sin(_angle2 * Math.PI / TriangleAnglesTotal);

    public new double GetSide3() =>
        base.GetSide3() * Math.Sin(_angle2 * Math.PI / TriangleAnglesTotal) / Math.Sin(_angle1 * Math.PI / TriangleAnglesTotal);

    public new double GetPerimeter() =>
        GetSide1() + GetSide2() + GetSide3();
}