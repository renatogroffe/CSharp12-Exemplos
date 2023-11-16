namespace ConsoleAppPrimaryConstructorClass.Models;

public class Projeto(string targetFramework, string descricao, List<string> tecnologias, double horasTrabalhadas = 8)
{
    public Projeto(string targetFramework, string descricao) :
        this(targetFramework, descricao, new List<string>()) { }

    public string TargetFramework => targetFramework;
    public string Descricao => descricao;
    public List<string> Tecnologias => tecnologias;
    public double HorasTrabalhadas { get; set; } = horasTrabalhadas;
}