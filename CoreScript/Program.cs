using CoreScript.UserEnvironment;

namespace CoreScript;

class Program
{
    static void Main()
    {
        if (!Initializer.InitCoreScript())
            return;

        UserEnvironmentClass.Start();
    }
}