using System.Runtime.CompilerServices;

namespace ConsoleAppInterceptors;

public static class InterceptorConsoleApp
{
    [InterceptsLocation(@"D:\DotNet8\CSharp12\ConsoleAppInterceptors\Program.cs", line: 4, character: 9)]
    public static void InterceptorMethodBegin(string value)
    {
        Console.WriteLine($"[Inicio({nameof(InterceptorMethodBegin)})] {value}");
    }

    [InterceptsLocation(@"D:\DotNet8\CSharp12\ConsoleAppInterceptors\EnvironmentVariablesHelper.cs", line: 7, character: 17)]
    public static void InterceptorMethodEnvVar(string value)
    {
        Console.WriteLine($"[Variavel({nameof(InterceptorMethodEnvVar)})] {value}");
    }

    [InterceptsLocation(@"D:\DotNet8\CSharp12\ConsoleAppInterceptors\Program.cs", line: 16, character: 9)]
    public static void InterceptorMethodEnd(string value)
    {
        Console.WriteLine($"[Fim({nameof(InterceptorMethodEnd)})] {value}");
    }
}