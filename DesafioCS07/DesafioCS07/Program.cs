using System;

namespace DesafioCS07
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());
            
            int horas = segundos/3600;
            int minutos = (segundos - (horas * 3600 ))/60;
            segundos  = segundos - (horas * 3600) - (minutos * 60);

            Console.Write(horas+":"+minutos+":"+segundos);
        }
    }
}
