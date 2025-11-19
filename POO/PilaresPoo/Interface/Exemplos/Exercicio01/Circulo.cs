
using Exemplos;

namespace Exercicios01
{
    public class Circulo : IForma
    {
        public float Raio;
        private float PI = 3.14f;
        public void CalcularArea()
        {
            float area = (float)Math.PI * Raio * Raio;
            Console.WriteLine($"A área do circulo é: {area}");
            
        }
    }
}