using System.Runtime.InteropServices;
using System.Text.Json;
using ConsoleAppPrimaryConstructorClass.Models;

Console.WriteLine("***** Testes com C# 12 | Primary Constructor em uma classe *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

var projeto01 = new Projeto("net7.0", "Worker Consolidacao Bancaria",
    new List<string>() { "Azure Functions", "Application Storage", "Azure Service Bus" });
projeto01.Tecnologias.Add("Application Insights");
projeto01.HorasTrabalhadas = 130.5;
Console.WriteLine($"{nameof(projeto01)}: {JsonSerializer.Serialize(projeto01)}");

Console.WriteLine();

var projeto02 = new Projeto("net8.0", "API de exemplo demonstrando novos recursos");
Console.WriteLine($"{nameof(projeto02)}: {JsonSerializer.Serialize(projeto02)}");