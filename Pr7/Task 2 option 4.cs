using System;

namespace Limerence
{
    class Program
    {
        static int max(int[,] mass)
        {
            double snum = ((mass.GetLength(0)) - 1) / 2; // (Вычисляет порядок среднего столбца)
            double left = snum;
            double right = snum;
            double max = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    if (i < snum)
                    {
                        if ((j >= left) && (j <= right))
                        {
                            if ((mass[i, j]) > max) max = mass[i, j];
                        }

                        if ((j == mass.GetLength(0) - 1))
                        {
                            left--;
                            right++;
                        }
                    }

                    if (i == snum)
                    {
                        if ((mass[i, j]) > max) max = mass[i, j];
                    }

                    if (i > snum)
                    {
                        if ((j == 0))
                        {
                            left++;
                            right--;
                        }
                        if ((j >= left) && (j <= right))
                        {
                            if ((mass[i, j]) > max) max = mass[i, j];
                        }
                    }
                }
            }



            Console.WriteLine("Максимальное число в заданой области равно = {0}", max);
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

            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Massive[i, j] = rand.Next(0, 10);
                    Console.Write(Massive[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("________________________________________________________________");

            max(Massive);
        }



    }
}