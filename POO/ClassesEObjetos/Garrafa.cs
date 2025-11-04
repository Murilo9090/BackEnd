
namespace ClassesEObjetos
{
    public class Garrafa
    {
        public double capacidade;
        public string marca;
        public string cor;
        public string material;

        //metados
        public void Abrir()
        {
            Console.WriteLine($"Abrindo Garrafa");
        }
        public void Encher()
        {
            Console.WriteLine($"Enchendo Garrafa");
        }
        public void Esvaziando()
        {
            Console.WriteLine($"Esvaziando Garrafa");
        }
       
        public void Fechando()
        {
            Console.WriteLine($"Fechando Garrafa");
        }


    }
}
