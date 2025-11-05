

namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public int Altura;//em centímetros

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos!");
        }
        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzz ...");
        }

        //se não treinar vai envelhver mais rapido4//

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                Idade += _id;
            }
            else
            {
                Idade++;
            }
        }
    }
}