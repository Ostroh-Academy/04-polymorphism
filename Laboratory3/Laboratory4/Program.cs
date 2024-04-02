using ConsoleTools;
using Laboratory4.Core;

namespace Laboratory4;

internal static class Program
{
    private static void Main()
    {
        Triangle triangle = new(4.0, 60.0, 45.0);
        ShowMenu(triangle);
    }

    private static void ShowMenu(Triangle triangle) =>
        new ConsoleMenu()
            .Add($"As {nameof(EquilateralTriangle)}", () => ShowEquilateralTriangleParameters(triangle))
            .Add($"As {nameof(Triangle)}", () => ShowTriangleParameters(triangle))
            .Add("Exit", ConsoleMenu.Close)
            .Configure(config => config.Title = "Choose how to work with triangle.")
            .Show();

    private static void ShowEquilateralTriangleParameters(EquilateralTriangle triangle)
    {
        Console.WriteLine($"{triangle.GetType().Name}:");
        Console.WriteLine($"Side length 1: {triangle.GetSide1()}");
        Console.WriteLine($"Side length 2: {triangle.GetSide2()}");
        Console.WriteLine($"Side length 3: {triangle.GetSide3()}");
        Console.WriteLine($"Angle 1: {triangle.GetAngle1()}");
        Console.WriteLine($"Angle 2: {triangle.GetAngle2()}");
        Console.WriteLine($"Angle 3: {triangle.GetAngle3()}");
        Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        Console.WriteLine();
        Console.ReadKey();
    }
    
    // ReSharper disable once SuggestBaseTypeForParameter
    private static void ShowTriangleParameters(Triangle triangle)
    {
        Console.WriteLine($"{triangle.GetType().Name}:");
        Console.WriteLine($"Side length 1: {triangle.GetSide1()}");
        Console.WriteLine($"Side length 2: {triangle.GetSide2()}");
        Console.WriteLine($"Side length 3: {triangle.GetSide3()}");
        Console.WriteLine($"Angle 1: {triangle.GetAngle1()}");
        Console.WriteLine($"Angle 2: {triangle.GetAngle2()}");
        Console.WriteLine($"Angle 3: {triangle.GetAngle3()}");
        Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        Console.WriteLine();
        Console.ReadKey();
    }
}