
// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) 
// informa se o resultado foi um empate, //]
//a vitória foi do primeiro time ou do segundo time.

int p1;
int p2;

Console.WriteLine($"placar do jogo");
Console.WriteLine();

Console.WriteLine($"gols do primeiro time");
p1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Gols do segundo time");
p2 = int.Parse(Console.ReadLine());

if (p1 > p2)
{
 Console.WriteLine($"vitória foi do primeiro time ");
 
}
else if (p1 < p2)
{
   Console.WriteLine($"vitória foi do segundo time");
}
else
{
     Console.WriteLine($"o resultado foi um empate");
    
}