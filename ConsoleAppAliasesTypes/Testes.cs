using ConversoesFahrenheit = double[];
using CalculoIMC = (double Peso, double Altura);

namespace ConsoleAppAliasesTypes;

public static class Testes
{
    public static void ConverterTemperaturas(
        ConversoesFahrenheit temperaturasFahrenheit)
    {
        Console.WriteLine();
        Console.WriteLine("Testes com o alias 'ConversoesFahrenheit'...");
        foreach (var tempFahrenheit in temperaturasFahrenheit)
        {
            var tempCelsius = Math.Round((tempFahrenheit - 32) / 1.8, 2);
            var tempKelvin = tempCelsius + 273.15;
            Console.WriteLine(
                $"{tempFahrenheit} graus Fahrenheit = {tempCelsius} graus Celsius = " +
                $"{tempKelvin} graus Kelvin");
        }
    }

    public static void CalcularIMC(CalculoIMC paramsCalculoIMC)
    {
        Console.WriteLine();
        Console.WriteLine($"Testes com o alias '{nameof(CalculoIMC)}'...");
        var imc = Math.Round(
            paramsCalculoIMC.Peso / (paramsCalculoIMC.Altura * paramsCalculoIMC.Altura), 1);
        string classificacao;
        if (imc <= 18.5)
            classificacao = "Magreza";
        else if (imc <= 25.0)
            classificacao = "Normal";
        else if (imc <= 29.9)
            classificacao = "Sobrepeso";
        else if (imc <= 40.0)
            classificacao = "Obesidade";
        else
            classificacao = "Obesidade Grave";
        Console.WriteLine($"Altura = {paramsCalculoIMC.Altura} | " +
            $"Peso = {paramsCalculoIMC.Peso} | " +
            $"IMC = {imc} | " +
            $"Classificacao = {classificacao}");
    }
}