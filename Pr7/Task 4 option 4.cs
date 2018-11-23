using System;

namespace Limerence
{
    class Program
    {
        static bool Test(int u)
        {
            if (u == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static int msv(int[,] mass, int k)
        {
            double max = mass[k - 1, 0];
            int check = 0;

            for (int i = k; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    if (mass[i, j] > max)
                    {
                        check = 1;
                    }
                }
                break;
            }
            Console.WriteLine(Test(check));
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

            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(0); j++)
                {
                    Massive[i, j] = rand.Next(0, 10);
                }
            }

            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(0); j++)
                {
                    Console.Write(Massive[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("¬ведите k = ");
            int num = System.Convert.ToInt32(Console.ReadLine());
            msv(Massive, num);
        }
    }
}