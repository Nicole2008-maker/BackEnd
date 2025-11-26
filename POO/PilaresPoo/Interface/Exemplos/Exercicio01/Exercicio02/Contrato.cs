namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;
        
        public void Imprimir()
        {
            Console.WriteLine($@" 
            Contrato : {Nome};
            Clasulas : {TextoClausulas}
            ");

        }
    }
}