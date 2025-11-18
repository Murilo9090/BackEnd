using Exercicios2;
Console.Clear();
Funcionario f1 = new Funcionario();
f1.Nome = " Samuel";
f1.SalarioBase = 50000;

Gerente g1 = new Gerente();
g1.Nome = "Murilo";
g1.SalarioBase = 15000000;
g1.Bonus = 2500;

System.Console.WriteLine($"Funcionario: {f1.Nome}, Salario: {f1.CalcularSalario()}");
System.Console.WriteLine($"Gerente: {g1.Nome}, Salario: {g1.CalcularSalario()}");