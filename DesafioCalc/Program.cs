//Pedir para o usuário digitar dois números e exibir a soma desses dois números :)

int primeiroNumero;
int segundoNumero;

Console.WriteLine("fale o primeiro numero?");
primeiroNumero = int.Parse(Console.ReadLine());

Console.WriteLine("fale o segundo numero?");
segundoNumero = int.Parse(Console.ReadLine());

int soma = primeiroNumero + segundoNumero;

Console.WriteLine($"a soma de {primeiroNumero} + {segundoNumero} é {soma}");

