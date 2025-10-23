/*
Faça um programa que pergunta para o usuarioa quantidade de numeros que ele
quer digitar.apos isso crie um laço que exiba o numero que o usuario digitar
apenas se for PAR. utilize a estrutura while
*/


int q = 0, i = 1, n = 1;


    Console.WriteLine("Digite quantos numeros voçe quer digitar");
    q = int.Parse(Console.ReadLine());

    while (n <= q)

{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());
    if(i % 2 == 0)

    {
        Console.WriteLine($"O numero digitado e par: {i}");
    }         

}