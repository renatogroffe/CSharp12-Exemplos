using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 12 | Valores default em Lambda Expressions *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var incrementar = (int valor, int incremento = 1) => valor + incremento;

Console.WriteLine();
Console.WriteLine(
    $"Incremento default = {incrementar.Method.GetParameters()[1].DefaultValue}");

Console.WriteLine();
int teste01 = 1;
Console.WriteLine($"{nameof(teste01)} = {teste01} | Valor inicial");
teste01 = incrementar(teste01);
Console.WriteLine($"{nameof(teste01)} = {teste01} | Depois de incrementar");
teste01 = incrementar(teste01);
Console.WriteLine($"{nameof(teste01)} = {teste01} | Segundo incremento");

Console.WriteLine();
int teste02 = 1000;
Console.WriteLine($"{nameof(teste02)} = {teste02} | Valor inicial");
teste02 = incrementar(teste02, 2);
Console.WriteLine($"{nameof(teste02)} = {teste02} | Depois de incrementar com 2");
teste02 = incrementar(teste02, 3);
Console.WriteLine($"{nameof(teste02)} = {teste02} | Depois de incrementar com 3");