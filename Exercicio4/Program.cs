﻿//4) Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.  
//    A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

// - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
// - ACESSO    NEGADO    caso    a    senha    seja    inválida

int senha;
int senhavalida = 1234;


Console.WriteLine($"Insira a senha ....");
senha = int.Parse(Console.ReadLine());

if (senha > senhavalida)
{
 Console.WriteLine($"ACESSO    NEGADO");
} else if (senha < senhavalida)
{
 Console.WriteLine($"ACESSO    NEGADO");
} else if (senha == senhavalida)
{
  Console.WriteLine($"ACESSO    PERMITIDO ");
    
}