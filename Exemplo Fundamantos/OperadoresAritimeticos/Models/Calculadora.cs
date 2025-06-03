using System;

namespace OperadoresAritimeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x * y}");
        }

        public void Modulo(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

        public void Potencia(double x, double y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(3, 3)}");
        }

        public void RaizQuadrada(int x)
        {
            Console.WriteLine($"√ {x} = {Math.Sqrt(x)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180.0;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"ƒ de {angulo} = {seno.ToString("F4")}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180.0;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"cos de {angulo} = {coseno.ToString("F4")}");
        }
        
         public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180.0;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tan de {angulo} = {tangente.ToString("F4")}");
        }
        
    }
}