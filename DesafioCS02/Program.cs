﻿using System;

namespace DesafioCS02
{
    class Program
    {
        static void Main() {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}