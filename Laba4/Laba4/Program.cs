using Laba4;

Rectangle rectangle = new Rectangle(5, 10, 2, 7);
Parallelepiped parallelepiped = new Parallelepiped(5, 10, 15, 2, 7, 3);

Console.WriteLine("Rectangle coefficients:");
rectangle.PrintCoefficients();
Console.WriteLine("Parallelepiped coefficients:");
parallelepiped.PrintCoefficients();

Console.WriteLine("\nEnter point coordinates (x, y) to check if it's inside the rectangle:");
Console.Write("x :> ");
double x = double.Parse(Console.ReadLine());
Console.Write("y :> ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine($"Is the point ({x}, {y}) inside rectangle: {rectangle.IsPointInside(x, y)}");

Console.WriteLine("\nEnter point coordinates (x, y, z) to check if it's inside the parallelepiped:");
Console.Write("x :> ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y :> ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("z :> ");
double z2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Is the point ({x2}, {y2}, {z2}) inside parallelepiped: {parallelepiped.IsPointInside(x2, y2, z2)}");