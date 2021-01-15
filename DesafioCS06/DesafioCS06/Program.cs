using System;

namespace DesafioCS06
{
    class Program
    {
        class Desafio
        {
            static void Main()
            {
                string[] entrada = Console.ReadLine().Split(" ");

                int n = int.Parse(entrada[0]);
                int d = int.Parse(entrada[1]);

                string data = "";
                int qtd = 0;
                bool found = false;

                for (int i = 0; i < d; i++)
                {
                    qtd = 0;
                    string[] dados = Console.ReadLine().Split(" ");
                    data = dados[0];
                    for (int j = 1; j < n + 1; j++)
                    {
                        qtd += int.Parse(dados[j]);
                    }
                    found = (qtd == n);
                    if (found) { break; }
                }
                if (found)
                {
                    Console.Write(data);
                }
                else { Console.Write("Pizza antes de FdA"); }
            }
        }
    }
}
