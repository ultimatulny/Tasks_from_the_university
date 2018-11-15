using System;

namespace Limerence
{
    class Program
    {
        static int Zero(int[,] mass)
        {
            double snum = ((mass.GetLength(0)) - 1) / 2;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    if ((i == 0) || (i == snum) || (i == mass.GetLength(1) - 1) || (j == mass.GetLength(1) - 1))
                    {
                        mass[i, j] = 0;
                    }
                    else mass[i, j] = 1;
                }
            }

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {

                    Console.Write(mass[i, j]);
                }
                Console.WriteLine();
            }

            return 0;
        }

        public static void Main(string[] args)
        {

            Random rand = new Random();
            int q = 0;

            while (true)
            {
                q = rand.Next(2, 24);
                if (q % 2 != 0) { break; }
            }

            int[,] Massive = new int[q, q];





            Zero(Massive);
        }



    }
}