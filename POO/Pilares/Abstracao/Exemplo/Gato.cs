namespace Exemplo
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"MIAUUUU");

        }
        public override void Mover()
        {
            Console.WriteLine($"PLOC PLOC PLOC");
        }
    }
}