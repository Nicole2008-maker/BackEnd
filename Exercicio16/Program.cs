//Uma empresa decide dar aumento aos funcionarios de acordo com o seu cargo,
//disposto na tabela abaixo

// Produção - 6.5
// Administrativo - 7.5
// Diretoria - 12
// salario = salario * 1.065

// De acordo com a tabela acima faça um programa que receba o cargo e o salário de um funcionario e calcule e imprima o salario reajustado.

string cargo;
double salario, salarioNovo;

float saldo = 200.95f;
double saldo2 = 200.95f;

Console.WriteLine($"Digite o cargo do funcionario, producao, administrativo ou diretoria...");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do funcionario");
salario = float.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065f);

}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075f);

}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12f);
}

else
{
    Console.WriteLine($"Cargo invalido");

}

Console.WriteLine($"O novo salario rajustado e {salarioNovo}");