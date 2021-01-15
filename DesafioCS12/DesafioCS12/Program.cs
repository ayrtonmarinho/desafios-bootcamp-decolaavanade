using System;

namespace DesafioCS12
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;
            while (valor < 3)
            {
                int l1 = int.Parse(Console.ReadLine());
                string[] l2 = Console.ReadLine().Split(" ");
                int[] t = Array.ConvertAll<string, int>(l2, int.Parse);

                int nvMax = 1;
                int nv = 0;

                for (int i = 0; i < l1; i++)
                {
                    if (t[i] < 10)
                    {
                        nv = 1;
                    }
                    else if (t[i] < 20)
                    {
                        nv = 2;
                    }
                    else if (t[i] >= 20)
                    {
                        nv = 3;
                    }
                    if (nv > nvMax)
                    {
                        nvMax = nv;
                    }
                }
                Console.WriteLine(nvMax);
                valor++;
            }

        }

    }
}
