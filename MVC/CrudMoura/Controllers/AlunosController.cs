using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class AlunosController
    {
        private readonly ILogger<AlunosController> _logger;

        public static List<Aluno> ListaDeFrutas = new List<Aluno
        >
      
        public AlunosController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

public static List<Aluno> listaDeAlunos = new List<Aluno>
{
      {
            new Aluno{ Id = 1, Nome = "Nicole Samara", Idade = 17, CPF = 10553, Serie = "2A"},
            new Aluno{ Id = 1, Nome = "Maria Clara", Idade = 18, CPF= 121323, Serie = "2B"},
            new Aluno{ Id = 1, Nome = "Beatriz Correia", Idade = 17, CPF = 100232, Serie = "2A"},
        };

}