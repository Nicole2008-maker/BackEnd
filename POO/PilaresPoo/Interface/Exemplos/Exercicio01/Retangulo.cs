using Exemplos;

namespace Exercicios01
{
    public class Retangulo : IForma
    {
        public float Largura;
        public float Altura;

        public Retangulo(float Largura, float Altura)
        {
            Largura = Largura;
            Altura = Altura;
        }
        public void CalcularArea()
        {
            float area = Largura * Altura;
            Console.WriteLine($"Area do retangulo: {area}");
            
        }
    }
}