namespace Exemplos
{
    public class Moto : IMotor
 
 {   public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Moto(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;

        }

         public void ExibirInfo()
         {
            Console.WriteLine($@"
            Informações do Veiculo:
            Cor:{Cor}
            Marca:{Marca}
            Modelo:{Modelo}
            Ano:{Ano}
             ");
            
         }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando.... VRUM VRUM");

        }

        public void Freiar()
        {
            Console.WriteLine($"Carro Freiando... IRRRRRRRH");
            
        }
    }
}