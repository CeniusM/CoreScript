using CoreScript.UserEnvironment.UserInput;

namespace CoreScript.UserEnvironment;

/// <summary>
/// The user enviroment is a static application
/// </summary>
internal class UserEnvironmentClass
{
    private static bool IsRunning;
    private static string CurrentPath;

    public static bool Init()
    {
        // userinput
        UserInputClass.SetLayout(new UserInputLayout(ConsoleColor.Green, ConsoleColor.Black, ">> "));
        IsRunning = true;

        return true;
    }

    public static void Start()
    {
        string input = "";
        bool InputMatches(string[] vals)
        {
            return vals.Contains(input);
        }
        while (IsRunning)
        {
            UserInputClass.GetLineInput(ref input);

            if (InputMatches(UICodes.Exit))
            {
                IsRunning = false;
            }
            else if (InputMatches(UICodes.Settings))
            {
                Settings.Menu();
            }
            


        }
    }
}
