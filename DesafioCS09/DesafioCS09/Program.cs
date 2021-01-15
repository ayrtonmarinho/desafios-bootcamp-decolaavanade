using System;

namespace DesafioCS09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] ab = Console.ReadLine().Split(" ");

            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);

            int soma = a+b;

            if(soma<=n){
                Console.WriteLine("Farei hoje!");
            }else{
                Console.WriteLine("Deixa para amanha!");
            }
        }
    }
}
