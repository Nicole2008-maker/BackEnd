//criar um menu igual ao menu abaixo:

//=== SISTEMA BANCARIO SIMPLES ===
// 1. Cadastrar Cliente
// 2. Depositar
// 3. Sacar
// 4. Transferir
// 5. Listar Clientes
// 0. Sair

//criar a variavel de opcao do menu 
//criar a estrutura do while
//dentro da estrututura do while, criar ao menu, e ao final exibir uma mensagem;
//"Pressione ENTER para continuar..." e fazer o sistema parar até o usuário digitar o <ENTER>

string[] nomes = new string[10];//array tamanho 10 - de 0 a 9
float[]  saldos = new float[10];
int totalClientes = 0;

int opcao; 

do
{
    Console.Clear();
    Console.WriteLine($@"
    
=== SISTEMA BANCARIO SIMPLES ===
1. Cadastrar Cliente
2. Depositar
3. Sacar
4.Transferir
5. Listar Clientes
0. Sair");

    Console.WriteLine($"Digite a opção");
    opcao = int.Parse(Console.ReadLine());

switch (opcao)
    {
        case 0:
    Console.WriteLine($"Encerrando programa...");
            break;

        case 1:
            CadastrarCliente();
             break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            ListarCliente();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;  
}


    Console.WriteLine($"Pressione <ENTER> para continuar...");
    Console.ReadLine(); 

} while (opcao != 0);

void CadastrarCliente()
{
    Console.WriteLine($"Funçãon cadastrar cliente em desenvolvimento");
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido");
        return;
    }
    Console.WriteLine($"Nome do cliente");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso");
    

}
void Depositar()
{
    Console.WriteLine($"Funçãon cadastrar cliente em desenvolvimento");

}
void Sacar()
{
    Console.WriteLine($"Funçãon cadastrar cliente em desenvolvimento");

}
void Transferir()
{
    Console.WriteLine($"Funçãon cadastrar cliente em desenvolvimento");

}
void ListarCliente() 

{
    Console.WriteLine($"=== Lista de Clientes ===");
for (int i = 0; i < totalClientes; i++)
{
    Console.WriteLine($"{i} - {nomes[i]} | Saldo R${saldos[i]}");
    
}
}

