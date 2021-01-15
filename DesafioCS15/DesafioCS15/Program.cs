using System;
using System.Collections.Generic;

namespace DesafioCS15
{
    class Program
    {
        static int contarDistintos(string[] colecao, int n)
        {
            int res = 0;

            for (int i = 1; i < n; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                {
                    if (colecao[i] == colecao[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    res++;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string[] colecao = new string[106];
            string joia;
            int tam = colecao.Length;
            for(int i=0; i<tam; i++){
                joia = Console.ReadLine();
                if(joia==""){
                    break;
                }else{
                    colecao[i] = joia;
                }
            }

            

            Console.WriteLine(contarDistintos(colecao, tam));
        }
    }
}
