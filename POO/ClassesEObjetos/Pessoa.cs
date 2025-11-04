using System.Data;
using System.Net.WebSockets;
using System.Security.Cryptography;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade = 0;

        public void Falar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome}");
        }

        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return Idade;
            }
            Idade += _anos;

            return Idade;
        }
    }
}