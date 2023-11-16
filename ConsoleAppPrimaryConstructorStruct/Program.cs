using System.Runtime.InteropServices;
using System.Text.Json;
using ConsoleAppPrimaryConstructorStruct.Models;

Console.WriteLine("***** Testes com C# 12 | Primary Constructor em um struct *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

var struct01 = new Demografia("Brasil", 2021, 213_000_000);

var struct02 = struct01;
struct02.Ano = 2022;
struct02.Populacao = 217_240_060;

var struct03 = new Demografia("Canada", 2023, 39_566_248);

Console.WriteLine($"{nameof(struct01)} = {JsonSerializer.Serialize(struct01)}");
Console.WriteLine();
Console.WriteLine($"{nameof(struct02)} = {JsonSerializer.Serialize(struct02)}");
Console.WriteLine();
Console.WriteLine($"{nameof(struct03)} = {JsonSerializer.Serialize(struct03)}");