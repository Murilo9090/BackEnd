/*
  Faça um programa que receba 3 numeros inteiros e imprima na tela
  a somatoria total dos numeros,utilizando o laço FOR
*/

int n, resultado = 0;

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine("Digite o numero: ");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}
   Console.WriteLine($"Somatoria total: {resultado}");