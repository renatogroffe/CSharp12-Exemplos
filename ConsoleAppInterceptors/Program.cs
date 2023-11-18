using ConsoleAppInterceptors;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 8 + C# 12 | Utilizando Interceptors *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine($"Data atual: {DateTime.Now:dd/MM/yyyy}");

Console.WriteLine();
EnvironmentVariablesHelper.ShowContent("VisualStudioEdition");
EnvironmentVariablesHelper.ShowContent("VisualStudioVersion");
EnvironmentVariablesHelper.ShowContent("VisualStudioDir");

Console.WriteLine();
Console.WriteLine("Concluindo os testes!");