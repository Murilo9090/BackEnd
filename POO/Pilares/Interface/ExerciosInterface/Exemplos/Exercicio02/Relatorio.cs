namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string TextoRelatorio ="";

        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }
        public void imprimir()
        {
        Console.WriteLine($"Responsavel: {Nome}...");
        Console.WriteLine($"TextoRelatorio");
        Console.WriteLine($"--");
        }
    }
}