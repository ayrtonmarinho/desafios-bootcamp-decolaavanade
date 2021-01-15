using System;

namespace DesafioCS04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(" ");
            while(Int32.Parse(entrada[0])<=0 || Int32.Parse(entrada[1])>=104)
            {
                entrada = Console.ReadLine().Split(" ");
            }
            int a = Int32.Parse(entrada[0]);
            int n = Int32.Parse(entrada[1]);
            double p = 0.10;

            for(int i = 1; i<10; i++){
                Console.Write(Math.Ceiling(((a*n)*p)));
                if(i!=9){
                    Console.Write("|");
                }
                p = p+0.1;
            }

        }
    }
}
