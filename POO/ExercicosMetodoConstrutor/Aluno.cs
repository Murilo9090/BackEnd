namespace ExercicosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome;
        public int Nota;

        //metodo contrutor de pessoa, possuindo parametros
        /*possui parametros - representam os valores de nome e idade
        ou seja, estamos inicializando valores para as props nome e idade*/
        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }
        public Aluno(string n)
        {
            Nome = n;
            Nota = 0;
        }
        public Aluno(string n, int i)
        {
            Nome = n;
            Nota = i;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Nota}");
        }
    }
}