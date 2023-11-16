using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com C# 12 | Collection Expressions *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

//int[] arrayCopasBrasil = new int[] { 1958, 1962, 1970, 1994, 2002 };
int[] arrayCopasBrasil = [1958, 1962, 1970, 1994, 2002];
Console.WriteLine($"{nameof(arrayCopasBrasil)} = {JsonSerializer.Serialize(arrayCopasBrasil)}");
Console.WriteLine();

int[] arrayCopasUruguai = [1930, 1950];
Console.WriteLine($"{nameof(arrayCopasUruguai)} = {JsonSerializer.Serialize(arrayCopasUruguai)}");
Console.WriteLine();

//Span<string> spanEstadosBrasil = new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
Span<string> spanEstadosBrasil = ["AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"];
Console.Write($"{nameof(spanEstadosBrasil)} = ");
foreach (var item in spanEstadosBrasil)
    Console.Write($"{item} ");
Console.WriteLine();

//ReadOnlySpan<string> readOnlySpancontinentes = new[] { "Africa", "America do Norte", "America do Sul", "Antartida", "Asia", "Europa", "Oceania" };
ReadOnlySpan<string> readOnlySpancontinentes = [ "Africa", "America do Norte", "America do Sul", "Antartida", "Asia", "Europa", "Oceania" ];
Console.Write($"{nameof(readOnlySpancontinentes)} = ");
foreach (var item in readOnlySpancontinentes)
    Console.Write($"{item}   ");
Console.WriteLine();

//int[][] array2DCopasPorDecada = { new int[] { 2002, 2006, 2010 }, new int[] { 2014, 2018 }, new int[] { 2022, 2026, 2030 } };
int[][] array2DCopasPorDecada = [[2002, 2006, 2010], [2014, 2018], [2022, 2026, 2030]];
Console.WriteLine($"{nameof(array2DCopasPorDecada)} = {JsonSerializer.Serialize(array2DCopasPorDecada)}");
Console.WriteLine();

//int[][] array2DCopasUruguaiBrasil = new int[][] { arrayCopasUruguai, arrayCopasBrasil };
int[][] array2DCopasUruguaiBrasil = [arrayCopasUruguai, arrayCopasBrasil];
Console.WriteLine($"{nameof(array2DCopasUruguaiBrasil)} = {JsonSerializer.Serialize(array2DCopasUruguaiBrasil)}");
Console.WriteLine();

//int[] arraySingleCopasUruguaiBrasil = arrayCopasUruguai.Concat(arrayCopasBrasil).ToArray();
int[] arraySingleCopasUruguaiBrasil = [..arrayCopasUruguai, ..arrayCopasBrasil];
Console.WriteLine($"{nameof(arraySingleCopasUruguaiBrasil)} = {JsonSerializer.Serialize(arraySingleCopasUruguaiBrasil)}");
Console.WriteLine();

//List<string> listRegioesBrasil = new List<string> { "Norte", "Nordeste", "Centro-Oeste", "Sudeste", "Sul" };
List<string> listRegioesBrasil = [ "Norte", "Nordeste", "Centro-Oeste", "Sudeste", "Sul" ];
Console.WriteLine($"{nameof(listRegioesBrasil)} = {JsonSerializer.Serialize(listRegioesBrasil)}");