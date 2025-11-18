using Exercicio02;

// cria os objetos do tipo Fatura
List<IImprimivel> documentos = new List<IImprimivel>();
// Fatura fatPedro = new Fatura("Pedro", "Davi", 50, 1);

// fatPedro.Imprimir();

//Criar um menu da seguinte forma:
int opcao;
do{
Console.WriteLine($"Menu de Opções");
Console.WriteLine($@"
1) Cadastrar fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatorios
6) Listar Contratos
0) Sair
Escolha a opção:
");
opcao = int.Parse(Console.ReadLine());


switch (opcao)
{
    case 1:
    Console.WriteLine($"Cadastrar Fatura");
    CadastrarFatura();
    break;
    
    case 2:
    Console.WriteLine($"Cadastrar Relatorio");
    CadastrarRelatorio();
    break;

    case 3:
    Console.WriteLine($"Cadastrar Contrato");
    CadastrarContrato();
    break;

    case 4:
    Console.WriteLine($"Listar Faturas");
    break;

    case 5:
    Console.WriteLine($"Listar Relatorios");
    break;

    case 6:
    Console.WriteLine($"Listar Contratos");
    break;

    case 0:
    Console.WriteLine($"Sair");
    break;
    default:
    Console.WriteLine($"Opção invalida");
    break;
}


Console.WriteLine($"Digite <Enter> para continuar ...");
Console.ReadLine();
} while (opcao != 0);

//Funções auxiliares

void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do Devedor: ");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome do Credor: ");
    string cred = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura: ");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Quantos dias a fatura esta em atraso? ");
    int DiasAtrasado = int.Parse(Console.ReadLine());



    Fatura f = new Fatura(dev, cred, Valor, DiasAtrasado);

    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante: ");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa contratada: ");
    string cred = Console.ReadLine();

    string TextoClausulas = Console.ReadLine();
    Console.WriteLine($"Texto clausulas: ");

   Contrato c = new Contrato("Murilo", "Bradesco Cartões", "ver clausulas");
   documentos.Add(c);
}

void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do Responsavel: ");
    string resp = Console.ReadLine();

    Console.WriteLine($"Texto relatorio: ");
    string txt = Console.ReadLine();

    Relatorio relatorio = new Relatorio(resp, txt);
    documentos.Add(relatorio);
}
void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas");
  foreach (var item in documentos)
  {
    if (item is Fatura)
        {
            item.imprimir();
        }
  }
}
void ListarContrato()
{
    Console.WriteLine($"Listando as contratos");
    foreach (var item in documentos)
    {
        if(item is Contrato)
        {
            item.imprimir();
        }
    }
}
void ListarRelatorios()
{
    Console.WriteLine($"Listando as relatorios");
    foreach (var item in documentos)
    {
        if(item is Relatorio)
        {
            item.imprimir();
        }
    }
}