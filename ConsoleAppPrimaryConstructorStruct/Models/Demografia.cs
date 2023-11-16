namespace ConsoleAppPrimaryConstructorStruct.Models;

public struct Demografia(string pais, int ano, int populacao)
{
    public string Pais => pais;
    public int Ano { get; set; } = ano;
    public int Populacao { get; set; } = populacao;
}