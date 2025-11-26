namespace Exercicio02
{
    public class Relatorio : IImprimivel

    {
        public string NomeResponsavel;
        public string TextoRelatorio;
        public void Imprimir()
        {
            Console.WriteLine($@"
            Responsavél: {NomeResponsavel} 
            Relatorio: {TextoRelatorio}
            ");

        }
    }
}