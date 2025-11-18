namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        public float PI = 3.14f;
        public void CalcularArea()
        {
            Console.WriteLine("O raio de circulo é {PI * Raio * Raio}");
        }
    }
}