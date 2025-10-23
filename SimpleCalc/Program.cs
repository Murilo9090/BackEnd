/* pedir o nome do usuario, dois numeros e mostrar a soma dos numeros no final*/

string nome;
int numero1;
int numero2;

//pedir os nome pro usuario
Console.WriteLine("Digite seu nome");//pede o nome do usuario
nome = Console.ReadLine();//exibe o nome do usuario

//Pedir os dois numeros
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());//converte o texto em numero
Console.WriteLine("Digite o sugundo numero");
numero2 = int.Parse(Console.ReadLine());//converte o texto em numero

//somar os dois numeros
int soma = numero1 + numero2;

//Exibir nome e a soma
Console.WriteLine(nome);//exibe o nome do usuario
Console.WriteLine(soma);//exibe o total da soma
