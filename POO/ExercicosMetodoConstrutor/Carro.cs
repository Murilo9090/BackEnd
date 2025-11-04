namespace ExercicosMetodoConstrutor
{
    public class Carro
    {
        public string marca;

        public string modelo;

        public int ano;

        public Carro(string c, string m, int a)
        {
            marca = c;
            modelo = m;
            ano = a;
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {marca}, Modelo{modelo}, Ano{ano}");
        }
    }
}