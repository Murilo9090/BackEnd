using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao
    {
        public string marca;
        public string modelo;
        public string QtdTurbina;

        public void ligar()
        {
            Console.WriteLine($"Ligando o aviao");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando o aviao");
        }

    }
}