
// Exercício 2 – Funcionários de uma empresa
// Crie uma classe Gerente que herde de Funcionario e possua um bônus adicional.

using System.IO.Pipes;

namespace exercicio02
{
    public class Gerente : funcionario
    {
        private float bonus ;

        public override float CalcularSalario()
        {
            return SalarioBase += bonus;
        }

    }
}