using System.Globalization;
using GeometricFigures.Entities;
using GeometricFigures.Menus.Common;

namespace GeometricFigures.Menus;

public class GeometricFigureMenu
{
    public Triangle ChooseFigure(string[] args)
    {
        var figure = new Triangle();

        var menuOptions = new Dictionary<string, Action>
        {
            { "Triangle", () => { figure = CreateTriangle(); } },
            { "Equilateral Triangle", () => { figure = CreateEquilateralTriangle(); } },
            { "Pyramid", () => { figure = CreatePyramid(); } },
            { "Tetrahedron", () => { figure = CreateTetrahedron(); } }
        };

        var menuConfiguration = new MenuConfiguration(title: "Create figure menu", writeHeaderAction: HeaderAction,
            enableCloseAfterOperationDone: true);

        var menu = menuConfiguration.CreateMenu(args, menuOptions);
        menu.ShowAsync();

        return figure!;

        void HeaderAction() => Console.WriteLine("Choose the type of figure you prefer:");
    }

    private static Triangle CreateTetrahedron()
    {
        var point1 = ReadPoint("Enter coordinates for Point1 (x y z): ");
        var point2 = ReadPoint("Enter coordinates for Point2 (x y z): ");
        var point3 = ReadPoint("Enter coordinates for Point3 (x y z): ");
        var point4 = ReadPoint("Enter coordinates for Point4 (x y z): ");

        var tetrahedron = new Tetrahedron();
        tetrahedron.SetCoordinates(point1, point2, point3, point4);

        return tetrahedron;
    }

    private static Triangle CreatePyramid()
    {
        var point1 = ReadPoint("Enter coordinates for Point1 (x y z): ");
        var point2 = ReadPoint("Enter coordinates for Point2 (x y z): ");
        var point3 = ReadPoint("Enter coordinates for Point3 (x y z): ");
        var point4 = ReadPoint("Enter coordinates for Point4 (x y z): ");

        var pyramid = new Pyramid();
        pyramid.SetCoordinates(point1, point2, point3, point4);

        return pyramid;
    }

    private static Triangle CreateEquilateralTriangle()
    {
        var point1 = ReadPoint("Enter coordinates for Point1 (x y z): ");
        var point2 = ReadPoint("Enter coordinates for Point2 (x y z): ");
        var point3 = ReadPoint("Enter coordinates for Point3 (x y z): ");

        var equilateralTriangle = new EquilateralTriangle();
        equilateralTriangle.SetCoordinates(point1, point2, point3);

        return equilateralTriangle;
    }

    private static Triangle CreateTriangle()
    {
        var point1 = ReadPoint("Enter coordinates for Point1 (x y z): ");
        var point2 = ReadPoint("Enter coordinates for Point2 (x y z): ");
        var point3 = ReadPoint("Enter coordinates for Point3 (x y z): ");

        var triangle = new Triangle();
        triangle.SetCoordinates(point1, point2, point3);

        return triangle;
    }

    private static Point3D ReadPoint(string prompt)
    {
        Console.Write(prompt);
        var coordinates = Console.ReadLine()?.Split(' ');
        if (coordinates == null || coordinates.Length != 3)
        {
            Console.WriteLine("Invalid input. Please enter three space-separated coordinates.");
            return ReadPoint(prompt);
        }

        if (double.TryParse(coordinates[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var x) &&
            double.TryParse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var y) &&
            double.TryParse(coordinates[2], NumberStyles.Any, CultureInfo.InvariantCulture, out var z))
        {
            return new Point3D(x, y, z);
        }

        Console.WriteLine("Invalid input. Please enter numeric coordinates.");
        return ReadPoint(prompt);
    }
}