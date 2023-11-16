using System.Runtime.InteropServices;
using ConsoleAppNameOfInstanceMembers.Models;

Console.WriteLine("***** Testes com C# 12 | nameof acessando instance members *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

var tests = new NameOfTests();
tests.PrintTestResults();