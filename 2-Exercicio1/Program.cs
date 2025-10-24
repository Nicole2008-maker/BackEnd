//1) Faça um programa que o usuário informe o salário recebido e o total gasto. 
// Deverá ser exibido na tela “Gastos dentro do orçamento” 
// caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

double salarioRecebido, totalGasto;


Console.WriteLine($"Qual o salário que você recebe?");
salarioRecebido = float.Parse(Console.ReadLine());
 Console.WriteLine($"Qual o total do seu gasto?");
totalGasto = float.Parse(Console.ReadLine());

    if (totalGasto >= salarioRecebido) 
    {
        Console.WriteLine($"Gastos dentro do orçamento!");
    }

    {
        Console.WriteLine($"Orçamento estourado {totalGasto}");
    }
    
