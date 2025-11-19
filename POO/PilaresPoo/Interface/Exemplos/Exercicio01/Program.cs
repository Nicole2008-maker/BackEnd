using Exercicios01;

Console.Clear();
Console.WriteLine($"Bem vindo ao programa de Geometria");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a área do retangulo!");

Console.WriteLine($"Informe a altura:");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a largura: ");
float largura = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine();

Console.WriteLine($"Agora vamos calcular a área do circulo");
Console.WriteLine($"Informe o raio do circulo");
float raio = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = raio;

retangulo.CalcularArea();
circulo.CalcularArea();
