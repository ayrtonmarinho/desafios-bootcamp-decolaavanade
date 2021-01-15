using System;

namespace DesafioCS10
{
    class Program
    {
        //Diz qual dia a placa poderá circular.
        static string verificaDiaDaPlaca(int digito)
        {
            switch (digito)
            {
                case 1:
                case 2:
                    return "SEGUNDA";
                case 3:
                case 4:
                    return "TERCA";
                case 5:
                case 6:
                    return "QUARTA";
                case 7:
                case 8:
                    return "QUINTA";
                case 9:
                case 0:
                    return "SEXTA";
                default:
                    return "";
            }
        }

        // Metodo que valida a string percorrendo ela em partes.
        static bool validarPlaca(string placa)
        {
            if (placa.Length != 8)
            {
                return false;
            }

            for (int i = 4; i < 8; i++)
            {
                if (!Char.IsDigit(placa, i))
                {
                    return false;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (!Char.IsUpper(placa, i))
                {
                    return false;
                }
            }

            if (placa.IndexOf('-') == -1)
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string placa = Console.ReadLine();

                if (!validarPlaca(placa))
                {
                    Console.WriteLine("FALHA");
                    continue;
                }

                int ultimoDigito = int.Parse(placa[placa.Length - 1].ToString());
                Console.WriteLine(verificaDiaDaPlaca(ultimoDigito));
            }
        }
    }
}
