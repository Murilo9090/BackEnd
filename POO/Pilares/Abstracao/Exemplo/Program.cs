using Exemplo;
Console.Clear();
ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo conta corrente antes do saque: R${cc.Saldo}");
Console.WriteLine($"Saldo conta poupança antes do saque: R${cp.Saldo}");
cc.Sacar(10);
cc.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo conta corrente apos o saque: R${cc.Saldo}");
Console.WriteLine($"Saldo conta poupança apos o saque: R${cp.Saldo}");