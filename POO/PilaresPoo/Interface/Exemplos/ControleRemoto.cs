

namespace exemplos
{
    public class ControleRemoto : IControle
    {

        public int NivelVolume = 30;
        public int VolumeMaximo = 30;

        

        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"volume maximo atingindo {NivelVolume}");
                return;
                
            }
            NivelVolume++;
            Console.WriteLine($"Aumentando o Volume da tv....{AumentarVolume}");
        }

        public void Desligar()
        {
          Console.WriteLine($"Desligando a tv.......");
          
        }

        public void DiminiirVolume()
        {
           Console.WriteLine($"Diminuindo o Volume da tv....{NivelVolume}");
        }

        public void ligar()
        {
            Console.WriteLine($"ligando a tv.......");
        }
    }
}