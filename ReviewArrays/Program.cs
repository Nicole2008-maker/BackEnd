string[] nomes = new string[4];//array tamanho 4 - de 0 a 3

nomes[0] = "Nikki";
nomes[1] = "Day";
nomes[2] = "Isa";

Console.WriteLine($"1o Nome : {nomes[0]}");
Console.WriteLine($"2o Nome : {nomes[1]}");
Console.WriteLine($"3o Nome : {nomes[2]}");
Console.WriteLine($"4o Nome : {nomes[3]}");
Console.WriteLine($"5o Nome : {nomes[4]}");


Console.WriteLine($"Tamanho do Array: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)//roda de 0 a 3
{
    Console.WriteLine($"   {i + 1}o Nome: {nomes[1]}");
}

