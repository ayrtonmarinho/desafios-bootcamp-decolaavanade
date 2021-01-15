using System;

namespace DesafioCS11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++){
                int p = 0;
                for(int j = 1; j<=3; j++){
                    p = p+1;
                    Console.Write(Math.Pow((i),p));
                    if(j!=3){
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
