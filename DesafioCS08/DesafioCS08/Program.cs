﻿using System;

namespace DesafioCS08
{
    class Program
    {
        static void Main(string[] args)
        {
            var idadeEmDias = int.Parse(Console.ReadLine());
            var anos = idadeEmDias/365; // Implemente aqui o calculo dos anos
            var meses = (idadeEmDias - (365 * anos))/30; // Implemente aqui o calculo dos meses 
            var dias = (idadeEmDias - (365*anos) )% 30; // Implemente aqui o calculo dos dias

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}
