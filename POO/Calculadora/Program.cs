using Calculadora;

Console.Clear();

Calculator calc = new Calculator();

calc.Numero1 = 50;
calc.Numero2 = 10;

Console.WriteLine($"===Calculator===");
Console.WriteLine($"Resultados: ");
Console.WriteLine($"Primeiro número: {calc.Numero1}");
Console.WriteLine($"Segundo número: {calc.Numero2}");


Console.WriteLine($"Soma: {calc.Somar()}");
Console.WriteLine();

Console.WriteLine($"Subtração: {calc.Subtrair()}");
Console.WriteLine();

Console.WriteLine($"Multiplicação: {calc.Multiplicar()}");
Console.WriteLine();

Console.WriteLine($"Divisão: {calc.Dividir()}");
Console.WriteLine();
