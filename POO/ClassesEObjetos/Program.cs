using ClassesEObjetos;

// Console.Clear();
// Garrafa g1 = new Garrafa();
// Console.Write($"Digite a marca da garrafa: ");
// string Marca = Console.ReadLine();

// Console.Write($"Digite a capacidade da garrafa: ");
// string Capacidade = Console.ReadLine();

// Console.Write($"Digite a cor da garrafa: ");
// string Cor = Console.ReadLine();

// Console.Write($"Digite o material da garrafa: ");
// string Material = Console.ReadLine();

// Console.Clear();
// Console.WriteLine($"---- Garrafa {Marca} ----");
// Console.WriteLine($"Marca: {Marca}");
// Console.WriteLine($"Capacidade: {Capacidade}ml");
// Console.WriteLine($"Cor da garrafa: {Cor}");
// Console.WriteLine($"Material da garrafa: {Material}");


// g1.Abrir();
// g1.Encher();
// g1.Esvaziando();
// g1.Fechando();


// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";

// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);
// Console.WriteLine($"{joao.Nome} tem {novaIdade} anos");

// novaIdade = joao.Envelhecer(-50);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
Console.Clear();
            
Console.WriteLine("-- Agência Bancária --");
 Console.Write("Digite o nome do titular: ");
 string nomeT = Console.ReadLine();

 ContaBancaria conta = new ContaBancaria(nomeT);

 Console.WriteLine();
 Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}!");
 Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");
Console.WriteLine();

// Loop do menu principal
 int opcao = 0;
 do
 {
     Console.WriteLine("\n--- Menu ---");
     Console.WriteLine("1. Depositar");
     Console.WriteLine("2. Sacar");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
     Console.WriteLine();

   switch (opcao)
   {
       case 1:
           Console.Write("Digite o valor do depósito: R$ ");
           double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(deposito);
           break;

      case 2:
          Console.Write("Digite o valor do saque: R$ ");
           double saque = Convert.ToDouble(Console.ReadLine());
           conta.Sacar(saque);
            break;

       case 0:
          Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opção inválida! Escolha uma das opções acima.");
             break;
    }

} while (opcao != 0);