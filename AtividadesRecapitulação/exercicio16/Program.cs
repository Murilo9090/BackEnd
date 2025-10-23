/*
Faça um programa que Uma empresa decide dar aumento aos os funcionarios de acordo com o seu cargo.
diposto na tabela abaixo.
     
    Cargo            %Aumento 
   Produção            6.5
 Administrativo        7.5
  Diretoria            12

  De acordo com a tabela acima faça um programa que receba o cargo e o salario de 
  um funcionario e calcule e imprima o salario reajustado.
*/

string cargo;
double salario, novoSalario, aumento = 0;

Console.WriteLine("Digite o cargo do funcionário:");
cargo = Console.ReadLine(); // converte para minúsculas para facilitar a comparação

Console.WriteLine("Digite o salário atual do funcionário:");
salario = double.Parse(Console.ReadLine());

if (cargo == "produção")
        {
            aumento = 6.5;
        }
        else if (cargo == "adm")
        {
            aumento = 7.5;
        }
        else if (cargo == "diretoria")
        {
            aumento = 12;
        }
        


    novoSalario = salario + (salario * aumento / 100);
{
    Console.WriteLine($"Cargo: {cargo}");
    Console.WriteLine($"Salário antigo: R$ {salario}");
    Console.WriteLine($"Aumento: {aumento}%");
    Console.WriteLine($"Novo salário: R$ {novoSalario}");
}


