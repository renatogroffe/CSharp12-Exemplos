using System.Runtime.InteropServices;
using ConsoleAppInlineArray.Models;

Console.WriteLine("***** Testes com C# 12 | Inline Arrays *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();


var eventosAcumuladosPorMes = new MesesAno<int>();
for (int i = 0; i < 12; i++)
    eventosAcumuladosPorMes[i] = (i * 3) + 2;

Console.WriteLine("*** Quantidade de eventos por mes ***");
int x = 0;
foreach (var qtdEventosMes in eventosAcumuladosPorMes)
    Console.WriteLine($"Mes {++x:00} = {qtdEventosMes}");