//pedir para o usuario digitar dois numeros em seguida verfique e exibir qual é o maior dos dois numeros
int n1, n2;

Console.WriteLine($"digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"o primeiro numero é o maior: {n1}");
}
else if (n2 > n1)
{
    Console.WriteLine($"o segundo numero é o maior: {n2}");
}
else
{
    Console.WriteLine($"os numeros são iguais: {n1} e {n2}");
}
