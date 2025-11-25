using Encapsulamento;

float dinheiro = 200;

ContaBancaria contaMuh = new ContaBancaria();
ContaBancaria contaDavi = new ContaBancaria(dinheiro);

contaMuh.Depositar(dinheiro);


System.Console.WriteLine($"Saldo do Murilo R$:{contaMuh.GetSaldo()}");
System.Console.WriteLine($"Saldo do Davi Muniz R$:{contaDavi.GetSaldo()}");

contaMuh.Saque(100);
System.Console.WriteLine($"Saldo após saque do Murilo: R$:{contaMuh.GetSaldo()}");