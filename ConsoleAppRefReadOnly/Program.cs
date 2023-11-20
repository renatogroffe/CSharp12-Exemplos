using ConsoleAppRefReadOnly;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 12 | ref readonly parameters *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

int numero = 0;
Console.WriteLine($"{numero}! = {Fatorial.Calcular(ref numero)}");

numero = 2;
Console.WriteLine($"{numero}! = {Fatorial.Calcular(in numero)}");

numero = 4;
Console.WriteLine($"{numero}! = {Fatorial.Calcular(ref numero)}");