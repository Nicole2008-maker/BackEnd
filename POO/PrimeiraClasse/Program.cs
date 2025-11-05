using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


Console.Clear();
Pessoa Nikki = new Pessoa();
Nikki.Nome = "Nicole Samara";
Nikki.Envelhecer(10);
Nikki.Altura = 164;

Console.WriteLine($"{Nikki.Nome} tem {Nikki.Idade} anos");
Nikki.Envelhecer(10);
Console.WriteLine($"{Nikki.Nome} tem {Nikki.Idade} anos");
