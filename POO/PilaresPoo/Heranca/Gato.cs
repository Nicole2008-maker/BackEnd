namespace Heranca
{
    public class Gato : Animal
    {
        public string Nome;

        public string Raça;

        public int Idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Raça: {Raça}, Idade: {Idade}");

        }
        public void FazerSom()
        {
            Console.WriteLine($"MEOW");
            
        }
    }
}