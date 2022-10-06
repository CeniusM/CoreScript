using CoreScript.UserEnvironment.UserInput;

namespace CoreScript.UserEnvironment;

internal class Settings
{
    public static UserInputLayout? UserInputLayout;

    private static readonly ColoredString[] MenuScreen = new ColoredString[]
    {
new(ConsoleColor.DarkYellow, "Stettings Menu:"),
new(ConsoleColor.Yellow, "Commands below with their name, follows by the command setup with command call name and args"),
new(ConsoleColor.White, "Exit Menu: leave || Leave"),
new(ConsoleColor.White, "UserInputString: UIP (string)"),
new(ConsoleColor.White, "UserInputColor: UIC"),
//new ColoredString(ConsoleColor.White, ""),
    };

    public static readonly string[] Leave = { "Leave", "leave" };

    public static void Menu()
    {
        bool IsRunning = true;
        string input = "";
        bool InputMatches(string[] vals)
        {
            return vals.Contains(input);
        }
        Output.Print(MenuScreen);
        while (IsRunning)
        {
            UserInputClass.GetLineInput(ref input);

            if (InputMatches(Leave))
            {
                IsRunning = false;
            }
        }

        Output.Print(new(ConsoleColor.Red, "Leaving settings menu"), false);
    }
}
