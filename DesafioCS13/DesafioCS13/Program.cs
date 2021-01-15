using System;

namespace DesafioCS13
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int v;
           
            do{
                v = int.Parse(Console.ReadLine());
            }while(v<=r);

            int cont = 1;

            int aux = r;

            while(aux <= v){
                cont = cont+1;
                r += 1;
                aux += r;
            } 

            Console.WriteLine(cont);
        }
    }
}
