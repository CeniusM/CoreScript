using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreScript.UserEnvironment;

namespace CoreScript.UserEnvironment.UserInput;

internal class UserInputClass
{
    public static UserInputLayout? tempLayout;

    public static void SetLayout(UserInputLayout layout)
    {
        Settings.UserInputLayout = layout;
    }

    public static void GetLineInput(ref string str)
    {
        tempLayout = Settings.UserInputLayout;
        if (tempLayout is null)
            return;
        Console.ForegroundColor = tempLayout.foregroundColor;
        Console.BackgroundColor = tempLayout.backgroundColor;
        Console.Write(tempLayout.inputPointer);
        str = Console.ReadLine()!;
    }
}
