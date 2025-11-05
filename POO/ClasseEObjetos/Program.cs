using ClasseEObjetos;

Console.Clear();
Console.WriteLine($"== Agência Bancária ==");
Console.WriteLine();

AgenciaBancaria contaDaNikki = new AgenciaBancaria();

contaDaNikki.Titular = "Elias Huamán";
contaDaNikki.Saldo = 1000.80f;

contaDaNikki.Depopsitar(500.01f);

contaDaNikki.Sacar(1500);
