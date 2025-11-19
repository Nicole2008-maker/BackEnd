using Exercicio02;

// List<Fatura> listaFaturas = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();










List<IImprimivel> documentos = new List<IImprimivel>();


int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"
Escolha uma das opções:

1) Cadastrar fatura
2) Cadastrar relátorio
3) Cadastrar contrato
4) Listar faturas
5) Listas relátorios
6) Listar contratos
0) Sair
");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
        Console.WriteLine($"Cadastrar Fatura em desenvolvimento");
            break;
        case 2:
        Console.WriteLine($"Cadastrar Relátorio em desenvolvimento");
            break;
        case 3:
        Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
        Console.WriteLine($"Listar Fatura em desenvolvimento");
            break;
        case 5:
        Console.WriteLine($"Listar Relátorios em desenvolvimento");
            break;
        case 6:
        Console.WriteLine($"Listar Contrato em desenvolvimento");
            break;
        case 0:
        Console.WriteLine($"Sair");
            break;

        default:
        Console.WriteLine($"Opção Inválida :( )");
        
        break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    

} while (opcao !=0);



void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da Empresa");
    string empresa = Console.ReadLine();
    
    Console.WriteLine($"Digite a quantidade da fatura");
    float valor = float.Parse(Console.ReadLine());
    
    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura cadastrada com sucesso!");
    
}

void CadastrarContratos()
{

}

void CadastrarRelatorios()
{

}

void ListarFaturas()
{
    Console.WriteLine($"Listando faturas: ");
    foreach (var item in documentos)

    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}
void ListarContratos()
{

}

void ListarRelatorios()
{
    
}




























// Fatura fatNikki = new Fatura();
// listaFaturas.Add(fatNikki);


// Fatura fatVick = new Fatura();
// listaFaturas.Add(fatVick);

// Relatorio relNikki = new Relatorio();
// listaRelatorio.Add(relNikki);

// Contrato contNikki = new Contrato();
// listaContrato.Add(contNikki);

// Console.WriteLine($"FATURAS: ");

// foreach (var Fatura in listaFaturas)
// {
//     Fatura.Imprimir();
// }

// Console.WriteLine($"RELATORIO: ");
// foreach (var Relatorio in listaFaturas)
// {
//     Relatorio.Imprimir();
// }

// Console.WriteLine($"CONTRATO:");
// foreach (var Contrato in listaFaturas)
// {
//     Contrato.Imprimir();
// }
