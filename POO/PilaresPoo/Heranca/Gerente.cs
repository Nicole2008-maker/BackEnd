
// Exercício 2 – Funcionários de uma empresa
// Crie uma classe Funcionario com as propriedades Nome e SalarioBase.

namespace exercicio02
{
    public class funcionario 
    {
        public string Nome;

        public float SalarioBase ;

        public virtual float CalcularSalario()
        {
            return SalarioBase;
        }
    }
}