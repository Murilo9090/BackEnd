namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        //metodo construtor de Pessoa,possui parametros
        //Paramentros representam os valores de nome e idade ou seja,estemanos inicializando valores para o props nome e idade
       
        public Pessoa(string n, int i)
        {
            Nome = n;  // inicializa com o valor de n
            Idade = i; // inicializa com o valor de i
        }
    
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}