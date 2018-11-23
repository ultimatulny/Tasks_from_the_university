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

            int check = 0;


            for (int i = k; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    if (mass[i, j] != mass[2, j])
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


            int[,] Massive = new int[5, 5];

            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(0); j++)
                {
                    Massive[i, j] = System.Convert.ToInt32(Console.ReadLine());
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