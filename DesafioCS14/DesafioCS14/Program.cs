using System;

namespace DesafioCS14
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[2];

            notas[0] = validarNota(Double.Parse(Console.ReadLine()));
            notas[1] = validarNota(Double.Parse(Console.ReadLine()));
            
            double media = (notas[0]+notas[1])/2;
            Console.WriteLine("media = "+media.ToString("N"));
        }

        static double validarNota(double valor)
        {
            while (valor < 0 || valor > 10)
            {
                Console.WriteLine("nota invalida");
                valor = Double.Parse(Console.ReadLine());
            }
            return valor;
        }
    }
}
