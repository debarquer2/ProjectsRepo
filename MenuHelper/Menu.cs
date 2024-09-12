namespace MenuHelper
{
    public class Menu
    {
        /// <summary>
        /// A struct containing strings and an action related to a menu option.
        /// </summary>
        /// <param name="title">The title to display.</param>
        /// <param name="input">The string to compare to user input to invoke the action.</param>
        /// <param name="action">The action to invoke based on user input.</param>
        public struct MenuOption(string input, string title, Action action, string description = "")
        {
            public string Input { get => input; set => input = value; }
            public string Title { get => title; set => title = value; }
            public Action Action { get => action; set => action = value; }
            public string Description { get => description; set => description = value; }
        }

        /// <summary>
        /// Shows a menu with options and prompts user for input. Call functions based on user input.
        /// </summary>
        /// <param name="menuOptions">Menu options</param>
        /// <param name="actions">Menu options functions</param>
        public void ShowMenu(MenuOption[] menuOptions)
        {
            string input = "";
            do
            {
                PrintMenuOptions(menuOptions);

                input = Console.ReadLine().ToLower();

                foreach (MenuOption menuOption in menuOptions)
                {
                    if (input == menuOption.Input)
                    {
                        menuOption.Action();
                    }
                }
            } while (input != "quit");
        }

        private static void PrintMenuOptions(MenuOption[] menuOptions)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("Command Name");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine($"{menuOptions[i].Input} {menuOptions[i].Title}");
                if (menuOptions[i].Description != "")
                {
                    Console.WriteLine(menuOptions[i].Description);
                }
            }
        }
    }
}
