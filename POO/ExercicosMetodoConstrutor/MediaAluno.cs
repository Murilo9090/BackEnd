namespace ExercicosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double n1, n2, n3;


        //construtor com parametros
        public MediaAluno(double param1, double param2, double param3)
        {

            n1 = param1;
            n2 = param2;
            n3 = param3;

            //Define os valores inicias para minahs propriedades
         }
        public MediaAluno()
        {
            n1 = n2 = n3 = 0;
        }
        public void Media()
        {
            double media = (n1 + n2 + n3) / 3;
            Console.WriteLine($"A media do(a) {Nome} foi: {Media}");
        }
    }
}