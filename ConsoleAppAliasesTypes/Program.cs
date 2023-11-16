using ConsoleAppAliasesTypes;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 12 | Utilizando Aliases para Tipos *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Testes.ConverterTemperaturas(new double[] { 86, 32, 212, 71.6, 104 });

Testes.CalcularIMC((70.5, 2.05));
Testes.CalcularIMC((75.12, 1.81));
Testes.CalcularIMC((130.0, 1.90));
Testes.CalcularIMC((150.0, 1.60));
Testes.CalcularIMC((70.98, 1.54));