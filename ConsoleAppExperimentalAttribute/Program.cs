using ConsoleAppExperimentalAttribute.Helpers;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 12 | ExperimentalAttribute *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

#pragma warning disable MessageHelper01 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
MessageHelper.ShowCurrentDateTime();
#pragma warning restore MessageHelper01 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.