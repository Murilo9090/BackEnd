
using System.Data;
using System.Dynamic;

namespace Desafio
{
    public class Carro
    {
        private string Marca = "";
        private string Modelo = "";
        private int velocidadeAtual;

        // Gets e Sets

        // Set Marca
        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }
        // Get da Marca
        public string ObterMarca()
        {
            return Marca;
        }

        // Set Modelo
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        // Get do Modelo
        public string ObterModelo()
        {
            return Modelo;
        }
        
        // Get da velocidade
        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }
        public void Acelerar(int valor)
        {
            if (valor > 0) 
                velocidadeAtual += valor;
        }
        public void Frear(int valor)
        {
            if (valor > 0)
                velocidadeAtual -= valor;
        }
    }
}