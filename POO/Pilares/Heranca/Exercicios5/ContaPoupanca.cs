using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios5
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            if(Saldo > 0){
            Saldo += 0.02f * Saldo;
            Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO, você não tem saldo o suficiente!");
            }
        }
    }
}