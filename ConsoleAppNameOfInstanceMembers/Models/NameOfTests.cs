using System.ComponentModel;
using System.Text.Json;

namespace ConsoleAppNameOfInstanceMembers.Models;

public class NameOfTests
{
    public static int AnoAtual = 1982;
    public string Observacao = "C# 12 ja lancado";
    public string Nome { get; } = "Renato Groffe";
    public string Test01 { get; } = nameof(Nome);
    public string Test02 { get; } = nameof(Nome.Length);
    public string Test03 { get; } = nameof(AnoAtual);
    public string Test04 { get; } = nameof(AnoAtual.MaxValue);

    [Description($"Uso em um atributo -> {nameof(Observacao.Length)}")]
    public int Test05 => Observacao.Length;
    
    public void PrintTestResults()
    {
        Console.WriteLine($"Conteudo do objeto = {JsonSerializer.Serialize(this)}");
        Console.WriteLine($"1o Teste | nameof(Nome) = {Test01}");
        Console.WriteLine($"2o Teste | nameof(Nome.Length) = {Test02}");
        Console.WriteLine($"3o Teste | nameof(AnoAtual) = {Test03}");
        Console.WriteLine($"4o Teste | nameof(AnoAtual.MaxValue) = {Test04}");

        var attributes = TypeDescriptor.GetProperties(this)["Test05"]!.Attributes;
        var test05Attribute = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)]!;
        Console.WriteLine($"5o Teste | [Description(... nameof(AnoAtual.MaxValue)) = " +
            test05Attribute.Description);
    }
}