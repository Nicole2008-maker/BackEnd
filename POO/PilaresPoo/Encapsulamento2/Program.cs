using Encapsulamento2;

ContaBancaria contaVick = new ContaBancaria();
ContaBancaria contaNikki = new ContaBancaria(1500);

contaNikki.Depositar(-100);
contaNikki.Depositar(20);

contaNikki.Sacar(-200);
contaVick.Sacar(300);

Console.WriteLine();

Console.WriteLine($"Saldo atual de Vick: R${contaVick.GetSaldo()}");
Console.WriteLine($"Saldo atual de Nikki: R${contaNikki.GetSaldo()}");
