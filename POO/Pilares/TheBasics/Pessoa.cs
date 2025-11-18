//namespace poder ser a pasta do projeto, namespace é o modulo do sistema
namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public Endereco EnderecoCompleto;
        public Pessoa(Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }



        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o {Nome} e Tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }

    }
}