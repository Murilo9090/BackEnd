namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat,int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }
        public void imprimir()
        {
            CalcularValorDivida();
            Console.WriteLine($@"
              Credor: {Credor}
              Devedor: {Devedor}
              Dias de Atraso:{DiasDeAtraso} Dia(s)
              Valor: { Valor:F2}
              Juros: { (Juros * DiasDeAtraso):F2}
              Total de Juros: {Valor:F2}
            ");
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }

            if(DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA");
            }
        }
    }
}