

namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string marca, string modelo, int ano)
        {
            //preechendo os dados inicias na classe
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            ExibirDados();//Ira exibir informacoes da classe

        }
        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
            
        }
    }
}