int opcao; // variavel de opcao que sera utilizada como condicao e DO WHITE, deve ser criada fora do laco do while

do
{

    Console.Clear(); //Limpa o console
    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine($"                       Bem Vindo                          ");
    Console.WriteLine($"                          ao                              ");
    Console.WriteLine($"                       JapaCama                           ");
    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine();
    // Hot holl
    // Temaki
    // Sashimi
    // Yakisoba
    // Guioza
    // Shimeji

    Console.WriteLine($"Escolha uma das opções abaixo:");
    Console.WriteLine();
    Console.WriteLine($"1)  Hot Holl ........................R$29,90");
    Console.WriteLine($"2)  Temaki   ........................R$30,00");
    Console.WriteLine($"3)  Sashimi  ........................R$67,20");
    Console.WriteLine($"4)  Yakisoba ........................R$35,90");
    Console.WriteLine($"5)  Guioza   ........................R$49,90");
    Console.WriteLine($"6)  Shimeji  ........................R$50,00");
    Console.WriteLine($"0)  Sair");
    Console.WriteLine($"Opção:");//exibe o texto sem pular linha
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
          
            break;

        case 1:
            HotHoll();
            break;

        case 2:
            Temaki();
            break; 

        case 3:
            Sashimi();
            break;

        case 4:
            Yakisoba();
            break;

        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção Inválida! QUe pena :( ");
            break;
    }

    //rodar o menu em loop
    //o menu deve rodar/aparecer pelo menos uma vez

  Console.WriteLine($"Digite <ENTER> para continuar...");
            Console.ReadLine();//so para parar o programa aqui
    } while (opcao != 0);



void HotHoll()
{
    Console.WriteLine($"Boa escolha! Estamos preparando seu Hot Holl com todo o amor possivel <3");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha! Estamos preparando seu Temaki com todo o amor possivel <3");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha! Estamos preparando seu Sashimi com todo o amor possivel <3");
}

void Yakisoba()
{
    Console.WriteLine($"Boa escolha! Estamos preparando seu Yakisoba com todo o amor possivel <3");
}

void Guioza(){

    Console.WriteLine($"Boa escolha! Estamos preparando seu Guioza com todo o amor possivel <3");
}

void Shimeji()
{
    Console.WriteLine($"Boa escolha! Estamos preparando seu Shimeji com todo o amor possivel <3");
}