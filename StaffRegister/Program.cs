using StaffRegister;
using MenuHelper;

public class Program
{
    static EmployeeManager employeeManager = new();
    static Menu menu = new();

    private static readonly Menu.MenuOption[] menuOptions = [
        new Menu.MenuOption("1", "Print employees", employeeManager.PrintEmployees),
        new Menu.MenuOption("2", "Add employee",    employeeManager.AddEmployee),
        new Menu.MenuOption("3", "Load from file",  employeeManager.LoadFile),
        new Menu.MenuOption("4", "Save to file",    employeeManager.SaveFile),
        new Menu.MenuOption("quit", "Quit",            () => { }),
    ];

    private static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            employeeManager.SaveFilePath = args[0];
        }

        if (File.Exists(employeeManager.SaveFilePath))
        {
            employeeManager.LoadFile();
        }

        menu.ShowMenu(menuOptions);
    }
}