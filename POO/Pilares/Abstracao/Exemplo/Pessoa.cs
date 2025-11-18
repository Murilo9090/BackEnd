namespace Exemplo
{
        public class Pessoa : Animal
    {
         public override void FazerSom()
        {
            Console.WriteLine($"Ola, eu sou uma pessoa");

        }
        public override void Mover()
        {
            Console.WriteLine($"dum dum dum ");
        }

    }    
}