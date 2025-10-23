/*
Faça um programa que solicite ao usuario um numero de repetições
"x". Para cada
repetição solicite dois numeros e imprima qual é o maior deles
*/

using System.Reflection;

int n = 0, contador = 0, n1 = 0, n2 = 0;

Console.WriteLine("Digite o numero de repetição");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    Console.WriteLine("Digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());

      if (n1 > n2)
         {
         Console.WriteLine($"O maior número é: {n1}");
         }
         else if (n2 > n1)
         {
         Console.WriteLine($"O maior número é: {n2}");
          }
          else
         {
          Console.WriteLine("Os dois números são iguais!");
         }




    contador++;

} 