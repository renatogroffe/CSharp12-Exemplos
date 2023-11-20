namespace ConsoleAppRefReadOnly;

public class Fatorial
{
    public static int Calcular(ref readonly int numero)
    {
        int resultado = 1;
        for (int i = numero; i > 1; i--)
            resultado *= i;

        return resultado;
    }
}
