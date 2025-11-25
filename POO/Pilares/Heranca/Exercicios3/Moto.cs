
namespace Exercicios3
{
    public class Moto : Veiculo
    {
        public string Capacete = "";
        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Modelo: {Modelo}
                                 Marca: {Marca}
                                 Capacete: {Capacete}");
        }
    }
}