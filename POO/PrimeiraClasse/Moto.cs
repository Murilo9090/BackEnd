namespace PrimeiraClasse
{
    public class Moto
    {
        public int qtdRodas;
        public string marca;
        public string modelo;
        public string cor;

        //metados
        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando");
        }
         public void Acelerando()
        {
            Console.WriteLine($"Moto Acelerando");
        }public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }
       
        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");
        }


    }
}