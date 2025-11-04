
namespace PrimeiraClasse
{
    public class Hello
    {
        //Propriedades/Caracteristicas - variaveis internas dessa classe
        public string TextoHello = "";

        //Metados/comportamentos/ações - são as funções internas dessa classe
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
 
        public void  SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }
}