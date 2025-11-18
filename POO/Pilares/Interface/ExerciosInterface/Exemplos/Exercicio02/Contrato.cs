using Exercicio02;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public void imprimir()
        {
         Console.WriteLine(@$"
         Partes:
         Contratante: {Contratante}
         Contratado: {PrestadorServico}
         Clausulas do Contrato :

         {TextoClausulas}
         
         ");   
         
        }
    }
}