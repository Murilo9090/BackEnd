namespace TheBasics
{
    public class Veiculo
    {
        public String marca;
        public string modelo;

        public int QtdRodas;


        public void Ligar()
        {
            Console.WriteLine($"Ligando o veiculo");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando veiculo");
        }


    }
}