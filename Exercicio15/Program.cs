//faça um programa que receba 4 notas de uma aluno, calcule e imprima a media aritmetica das notas e a mensagemde APROVADO para media superior ou igual a 7,0 recuperacao para notas entre 5,0 e 7,0 ou a mensagem de REPROVADO para media inferior a 5,0

float nota1 , nota2 , nota3 , nota4;

Console.WriteLine($"digite o primeiro nota");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o segunda nota");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o terceira nota");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o quarta nota");
nota4 = float.Parse(Console.ReadLine());


float media = (nota1 + nota2 + nota3 + nota4) /4;

Console.WriteLine($"media: {media}");

if (media >= 7)
{
    Console.WriteLine($"APROVADO");
}
else if (media >= 5)
{
    Console.WriteLine($"recuperacao");
}
else
{
    Console.WriteLine($"reprovado");
}