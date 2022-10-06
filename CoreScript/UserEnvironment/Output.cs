

namespace CoreScript.UserEnvironment;

internal class ColoredString
{
    public ConsoleColor Color;
    public string Str;

    public ColoredString(ConsoleColor color, string str)
    {
        this.Color = color;
        this.Str = str;
    }

    public static implicit operator string(ColoredString output)
    {
        return output.Str;
    }

    public static implicit operator ConsoleColor(ColoredString output)
    {
        return output.Color;
    }
}

internal class Output
{
    public static void Print(ColoredString output, bool AmiguesForSomeReason)
    {
        Console.ForegroundColor = output;
        Console.WriteLine(output);
    }

    public static void Print(ColoredString[] output)
    {
        foreach (ColoredString item in output)
        {
            Console.ForegroundColor = item;
            Console.WriteLine(item);
        }
    }
}
