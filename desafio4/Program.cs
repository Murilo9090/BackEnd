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