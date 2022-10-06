

namespace CoreScript;

internal class Initializer
{
    public static bool InitCoreScript()
    {
        if (!UserEnvironment.UserEnvironmentClass.Init())
            return false;

        return true;
    }
}
