namespace Laboratory4.Core;

internal sealed class TriangleFactory
{
    public Triangle CreateTriangle(double sideLength, double angle1, double angle2) =>
        new(sideLength, angle1, angle2);
    
    public EquilateralTriangle CreateEquilateralTriangle(double sideLength) =>
        new(sideLength);
}