namespace ConsoleAppInterceptors;

public static class EnvironmentVariablesHelper
{
    public static void ShowContent(string variableName)
    {
        Console.WriteLine(
            $"{variableName} = {Environment.GetEnvironmentVariable(variableName)}");
    }
}