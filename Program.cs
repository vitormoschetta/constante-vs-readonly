Teste.estatica = "estatica nova";
// Teste.constante = "constante nova";

var teste = new Teste("apenasLeitura nova");
// teste.apenasLeitura = "apenas leitura nova";

Console.WriteLine(Teste.estatica);
Console.WriteLine(Teste.constante);
Console.WriteLine(teste.apenasLeitura);

public class Teste
{
    public Teste(string texto)
    {
        apenasLeitura = texto;
    }
    public static string estatica = "estatica";
    public const string constante = "constante nao pode alterar";
    public readonly string apenasLeitura = "apenasLeitura";
}