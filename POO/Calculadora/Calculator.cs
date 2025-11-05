namespace Calculadora
{
    public class Calculator
    {
        public double Numero1;
        public double Numero2;
        public double Resultado;

        public double Somar()
        {
            Resultado = Numero1 + Numero2;
            return  Resultado;
        }

        public double Subtrair()
        {
            Resultado = Numero1 - Numero2;
             return  Resultado;
        }
        public double Multiplicar()
        {
           Resultado = Numero1 *Numero2;
            return  Resultado;
        }
        
        public double Dividir()
        {
            Resultado = Numero1 / Numero2;
            return  Resultado;
        }
    }
}