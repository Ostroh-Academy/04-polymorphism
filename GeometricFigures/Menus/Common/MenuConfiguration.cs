using ConsoleTools;

namespace GeometricFigures.Menus.Common;

public class MenuConfiguration
{
    private readonly string _selector;
    private readonly string _title;
    private readonly Action _writeHeaderAction;
    private readonly bool _enableWriteTitle;
    private readonly bool _enableBreadcrumb;
    private readonly bool _enableCloseAfterOperationDone;

    public MenuConfiguration(string title, bool enableCloseAfterOperationDone, string? selector = null, Action? writeHeaderAction = null, bool? enableWriteTitle = null, bool? enableBreadcrumb = null)
    {
        _title = title;
        _enableCloseAfterOperationDone = enableCloseAfterOperationDone;
        _selector = selector ?? "--> ";
        _writeHeaderAction = writeHeaderAction ?? (() => Console.WriteLine("What action do you want to proceed:"));
        _enableWriteTitle = enableWriteTitle ?? false;
        _enableBreadcrumb = enableBreadcrumb ?? true;
    }

    public ConsoleMenu CreateMenu(string[] args, Dictionary<string, Action> menuOptions)
    {
        var menu = new ConsoleMenu(args, 0)
            .Configure(config =>
            {
                config.Selector = _selector;
                config.Title = _title;
                config.WriteHeaderAction = _writeHeaderAction;
                config.EnableWriteTitle = _enableWriteTitle;
                config.EnableBreadcrumb = _enableBreadcrumb;
            });

        foreach (var option in menuOptions)
        {
            menu.Add(option.Key, thisMenu =>
            {
                option.Value();
                if (_enableCloseAfterOperationDone)
                {
                    thisMenu.CloseMenu();
                }
            });
        }

        menu.Add("Exit", () => Environment.Exit(0));
        return menu;
    }
}
