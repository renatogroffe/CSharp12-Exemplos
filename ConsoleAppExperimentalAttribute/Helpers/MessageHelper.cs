using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppExperimentalAttribute.Helpers;

public static class MessageHelper
{
    [Experimental(diagnosticId: "MessageHelper01")]
    public static void ShowCurrentDateTime()
    {
        Console.WriteLine($"Executando o metodo experimental " +
            $"{nameof(MessageHelper)}.{nameof(ShowCurrentDateTime)}");
        var now = DateTime.UtcNow.AddHours(-3);
        Console.WriteLine($"Data: {now:dd} de {now:MMMM} de {now:yyyy}");
        Console.WriteLine($"Horario atual: {now:HH:mm:ss}");
    }
}
