using MetodoConstrutor;

// Pessoa Murilo = new Pessoa ("Murilo", 16); // construtor chamado automaticamente

// // Murilo.Nome = "Murilo";
// // Murilo.Idade = 16;

// Console.WriteLine($"O objeto pessoa que criei é o {Murilo.Nome} com a idade {Murilo.Idade}");

// // Murilo.Nome = "Davi";

// Murilo.ExibirDados();
// Console.WriteLine($"{Murilo.Nome}");
// // 


Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas("Murilo");
Console.WriteLine($"Primeira pessoa cadastrada: Nome: {PrimeiraPessoa.Nome} {PrimeiraPessoa.Idade}");

Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Pedro");
Console.WriteLine($"Primeira pessoa cadastrada: Nome: {SegundaPessoa.Nome} {SegundaPessoa.Idade}");

Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Davi",17);
Console.WriteLine($"Primeira pessoa cadastrada: Nome: {TerceiraPessoa.Nome} {TerceiraPessoa.Idade}");

Console.WriteLine($"Digite seu nome: ");
TerceiraPessoa.Nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade: ");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Terceira pessoa cadastrada: Nome: {TerceiraPessoa.Nome} Idade: {TerceiraPessoa.Idade}" );

