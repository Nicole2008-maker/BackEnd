namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public int Nota;

        public Aluno()
        {
            Console.WriteLine($"Lista de alunos: ");
        }

        public Aluno(string a, int n)
        {
            Nome = a;
            Nota = n;
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} | Nota: {Nota}");
            
        }
    }
}