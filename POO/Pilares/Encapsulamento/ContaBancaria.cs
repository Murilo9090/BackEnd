namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;
        //Contrutores
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial >= 0)
            {
                Saldo = saldoInicial;
                return;
            }
        }

        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
                Saldo = valor;
                return;
            }
            System.Console.WriteLine($"Valor para deposito invalidado");
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Saque(float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"Saque efetuado com sucesso!!!");
                return;
            }
        }
    }
}