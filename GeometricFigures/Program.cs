using GeometricFigures.Menus;

namespace GeometricFigures;

internal static class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(5000);

        var geometricFigure = new GeometricFigureMenu();
        var account = geometricFigure.ChooseFigure(args);

        var accountActionsMenu = new GeometricFigureActionsMenu();
        accountActionsMenu.PerformFigureActions(args, account);
    }
}