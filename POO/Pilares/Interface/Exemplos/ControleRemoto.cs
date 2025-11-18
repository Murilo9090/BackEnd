namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if(NivelVolume < VolumeMaximo)
            {
                NivelVolume++;
                Console.WriteLine($"Nivel atual do volume: {NivelVolume}");
            }else
            {
                Console.WriteLine($"o volume ja atingiu o volume maximo {NivelVolume}");
            }

        }
            public void Desligar()
        {
            Console.WriteLine($"Desligando TV...");
        }

        public void DiminuirVolume()
        {
            if(NivelVolume == 0)
            {
                Console.WriteLine($"O volume ja esta no minimo {NivelVolume}");
            }else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV...");
        }
     
    }
}