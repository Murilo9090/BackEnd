using PrimeiraClasse;

// string nome = "Murilo Silva";

// //cria um objeto do tipo hello
// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Murilo Silva");

// Carro c1 = new Carro();
// c1.marca = "Lamborghini";
// c1.modelo = "Urus";
// c1.cor = "Preta";
// c1.qtdPortas = 4;
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerar();
// c1.Frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chevrolet";
// c2.modelo = "Camaro";
// c2.cor = "Amerelo";
// c2.qtdPortas = 2;
// c2.qtdRodas = 4;
// c2.Ligar();
// c2.Acelerar();
// c2.Frear();
// c2.Desligar();

// Console.WriteLine($"-------- Caracteristicas --------");
// Console.WriteLine();

// Console.WriteLine($"------- {c1.marca} -------");
// Console.WriteLine($"Carro: {c1.marca}");
// Console.WriteLine($"Modelo: {c1.modelo}");
// Console.WriteLine($"Cor: {c1.cor}");
// Console.WriteLine($"Quantidade de portas: {c1.qtdPortas}");
// Console.WriteLine();
// Console.WriteLine($"---");
// Console.WriteLine();


// Console.WriteLine($"------- {c2.marca} -------");
// Console.WriteLine($"Carro: {c2.marca}");
// Console.WriteLine($"Modelo: {c2.modelo}");
// Console.WriteLine($"Cor: {c2.cor}");
// Console.WriteLine($"Quantidade de portas: {c2.qtdPortas}");
// Console.WriteLine();


// Moto c1 = new Moto();
// c1.marca = "Yamaha";
// c1.modelo = "Tracer-900";
// c1.cor = "Preta";
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerando();
// c1.Frear();
// c1.Desligar();

// Moto c2 = new Moto();
// c2.marca = "BWM";
// c2.modelo = "S1000rr";
// c2.cor = "Vermelho";
// c2.qtdRodas = 4;
// c2.Ligar();
// c2.Acelerando();
// c2.Frear();
// c2.Desligar();

//  Console.WriteLine($"-------- Caracteristicas --------");
// Console.WriteLine();

//   Console.WriteLine($"------- {c1.marca} -------");
//  Console.WriteLine($"Moto: {c1.marca}");
//  Console.WriteLine($"Modelo: {c1.modelo}");
//  Console.WriteLine($"Cor: {c1.cor}");
//  Console.WriteLine();
//  Console.WriteLine($"---");
// Console.WriteLine();

//   Console.WriteLine($"------- {c2.marca} -------");
//  Console.WriteLine($"Moto: {c2.marca}");
//  Console.WriteLine($"Modelo: {c2.modelo}");
//  Console.WriteLine($"Cor: {c2.cor}");
//  Console.WriteLine();
//  Console.WriteLine($"---");
//  Console.WriteLine();

Console.Clear();
Garrafa g1 = new Garrafa();
Console.Write($"Digite a marca da garrafa: ");
string Marca = Console.ReadLine();

Console.Write($"Digite a capacidade da garrafa: ");
string Capacidade = Console.ReadLine();

Console.Write($"Digite a cor da garrafa: ");
string Cor = Console.ReadLine();

Console.Write($"Digite o material da garrafa: ");
string Material = Console.ReadLine();

Console.Clear();
Console.WriteLine($"---- Garrafa {Marca} ----");
Console.WriteLine($"Marca: {Marca}");
Console.WriteLine($"Capacidade: {Capacidade}ml");
Console.WriteLine($"Cor da garrafa: {Cor}");
Console.WriteLine($"Material da garrafa: {Material}");



/*
g1.Marca = Marca;
g1.Capacidade = ;
g1.Material = "Alumínio";
g1.Cor = "Azul";
*/
g1.Abrir();
g1.Encher();
g1.Esvaziando();
g1.Fechando();








