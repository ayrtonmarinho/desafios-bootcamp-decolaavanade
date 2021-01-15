using System;

namespace DesafioCS05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] l1 = Console.ReadLine().Split(" ");
            string[] l2 = Console.ReadLine().Split(" ");

            int[] refeicoes = Array.ConvertAll<string, int>(l1, int.Parse);
            int[] passageiros = Array.ConvertAll<string, int>(l2, int.Parse);

            int total=0;

            for(int i = 0; i<3; i++){
                if(refeicoes[i]<passageiros[i]){
                    total += Math.Abs(refeicoes[i]-passageiros[i]);
                }
            }
            Console.Write(total);
        }
    }
}
