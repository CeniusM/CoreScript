

namespace CoreScript.UserEnvironment.UserInput;

internal class UserInputLayout
{
    public ConsoleColor foregroundColor;
    public ConsoleColor backgroundColor;
    public string inputPointer;

    public UserInputLayout(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string inputPointer)
    {
        this.foregroundColor = foregroundColor;
        this.backgroundColor = backgroundColor;
        this.inputPointer = inputPointer;
    }
}
