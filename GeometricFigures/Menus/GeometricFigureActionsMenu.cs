using GeometricFigures.Entities;
using GeometricFigures.Menus.Common;

namespace GeometricFigures.Menus;

public class GeometricFigureActionsMenu
{
    public void PerformFigureActions(string[] args, Triangle figure)
    {
        var menuOptions = new Dictionary<string, Action>
        {
            { "Print coordinates", () => PrintSpecificCoordinates(figure) },
            { "Calculate area", () => CalculateFigureArea(figure) }
        };

        var menuConfiguration = new MenuConfiguration("Figure action menu", enableCloseAfterOperationDone: false);

        var menu = menuConfiguration.CreateMenu(args, menuOptions);
        menu.ShowAsync();
    }

    private void PrintSpecificCoordinates(Triangle figure)
    {
        Console.WriteLine($"{figure.GetType().Name}: \n\n{figure.PrintCoordinates()}");
        Thread.Sleep(5000);
    }

    private void CalculateFigureArea(Triangle figure)
    {
        Console.WriteLine($"Area of the {figure.GetType().Name}: {figure.CalculateArea():F2}");
        Thread.Sleep(5000);
    }
}