      int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE EXERCÍCIOS ===");
            Console.WriteLine("1 - Verificar orçamento");
            Console.WriteLine("2 - Mostrar placar de futebol");
            Console.WriteLine("3 - Tipo de triangulo");
            Console.WriteLine("4 - Mostrar senha");
            Console.WriteLine("5 - Comprar maças");
            Console.WriteLine("6 - Media do aluno");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    

    // === Funções dos exercícios ===

    void Exercicio1()
    {
          double salario, gastos;

        Console.Write("Digite o salário recebido: R$ ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o total gasto: R$ ");
        gastos = double.Parse(Console.ReadLine());

        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento.");
        }
        else
        {
            Console.WriteLine("Orçamento estourado!");
        }
        
    }

    void Exercicio2()
    {
       int Corinthians, Santos;

        Console.Write("Digite o número de gols do primeiro time: ");
        Corinthians = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de gols do segundo time: ");
        Santos = int.Parse(Console.ReadLine());

        if (Corinthians > Santos)
        {
            Console.WriteLine("Vitória do Corinthians!");
        }
        else if (Santos > Corinthians)
        {
            Console.WriteLine("Vitória do Santos!");
        }
        else
        {
            Console.WriteLine("O jogo terminou empatado!");     
        }
    }

    void Exercicio3()
    {
       double lado1, lado2, lado3;

        Console.Write("Digite o valor do primeiro lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        lado3 = double.Parse(Console.ReadLine());

        // Primeiro, verifica se as medidas formam um triângulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero (3 lados iguais).");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles (2 lados iguais).");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno (3 lados diferentes).");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo.");
        }
    }

    void Exercicio4()
    {
       int senha =1234;

Console.WriteLine("Digite a senha");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("Acesso Permetido");
}
else
{
    Console.WriteLine("Acesso Negado");
}
    }

     void Exercicio5()
    {
       
int quantidade;
double preco;
Console.WriteLine("Digite o numero de maças");
quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12)
{
    preco = 0.25;
}
else
{
    preco = 0.30;
}

 double total = quantidade * preco;

Console.WriteLine($"O valor total da compra é: R$ {total}");
    }

    static void Exercicio6()
    {Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno (em %): ");
        double frequencia = double.Parse(Console.ReadLine());
 if (frequencia < 75)
        {
            Console.WriteLine("Aluno REPROVADO por frequência.");
        }
        else if (media >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO.");
        }
        else if (media >= 3.0)
        {
            Console.WriteLine("Aluno em RECUPERAÇÃO.");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO por média.");
        }
    }
