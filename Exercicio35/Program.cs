int qtdVezes = 0;
Console.WriteLine("Quantos números voce quer digitar??");
int x = int.Parse(Console.ReadLine());
int n1, n2;
int contador = 1;

while (contador <= x)

{ 

    Console.WriteLine($"Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {//primeiro é o maior
        Console.WriteLine($"O numero {n1} é maior que {n1}");

    }
    else if (n2 > n1)
    {//segundo é o maior
        Console.WriteLine($"O numero {n2} é maior que {n1}");

    }
    else
        Console.WriteLine($"{n1} e {n2} são iguais!");


    }

     contador++;
