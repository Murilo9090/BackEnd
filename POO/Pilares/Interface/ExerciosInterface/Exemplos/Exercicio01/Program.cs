using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;
using Exercicio01;
Console.Clear();
Console.WriteLine($"Bem Vindo ao programa calculos de Geometria :");
Console.WriteLine($"");

Console.WriteLine($"Vamos calcular");

//Altura e Largura
Console.Write($"Digite a Largura do Retangulo: ");
float l = float.Parse(Console.ReadLine());
Console.Write($"Digite a Altura do Retangulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a area do circulo");
Console.WriteLine($"Informe o raio e circulo:");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do pragrama");
Console.WriteLine($"");




