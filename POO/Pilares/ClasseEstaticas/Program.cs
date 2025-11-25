using ClasseEstaticas;
Console.WriteLine($"Bem vindo ao programa");
// Console.WriteLine();

// Console.WriteLine($"Digite um numero: ");
// float a = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite outro numero: ");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// Console.WriteLine($"Soma {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// Console.WriteLine($"Subtração {r}");

// r = CalculosMatematicos.Divisao(a, b);
// Console.WriteLine($"Divisão {r}");

// r = CalculosMatematicos.Multiplicação(a, b);
// Console.WriteLine($"Multiplicação {r}");



//Solicitar ao usuario 2 numeros reais e informal qual é o maior e qual é o menor dos
//numeros. Para isso voce deve utilizar a classe Math, utilitaria do C#

 Console.WriteLine($"Digite um numero: ");
 float c = float.Parse(Console.ReadLine());
 Console.WriteLine($"Digite outro numero: ");
 float d = float.Parse(Console.ReadLine());

 System.Console.WriteLine(@$"O maior numero é: {Math.Max(c, d)}
é o menor é {Math.Min(c, d)}");
 