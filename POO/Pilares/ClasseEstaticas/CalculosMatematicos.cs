namespace ClasseEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matématicas simples
        // Visibilidade tipoDeRetorno Nome(parametros){corpo}
        public static float Somar(float a, float b)
        {
           return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }
        public static float Divisao(float a, float b)
        {
            if(b == 0)
            {
                Console.WriteLine($"Divisão");
                System.Console.WriteLine("Indefinido");
            }
            return a / b;
        }
        public static float Multiplicação(float a, float b)
        {
            return a * b;
        }
    }
}