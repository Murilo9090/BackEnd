namespace Exemplo
{
    public class Cachorro : Animal
    {
         public override void FazerSom()
        {
            Console.WriteLine($"AU AU");

        }
        public override void Mover()
        {
            Console.WriteLine($"PLOC PLOC PLOC");
        }
    }
}