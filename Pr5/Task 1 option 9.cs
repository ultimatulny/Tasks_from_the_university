using System;

namespace Program
{
    class Program
    {
        public static double fact(double h)
        {
            double z = 1;
            for (int i = 1; i <= h; i++)
            {
                z *= i;
            }
            return z;
        }

        public static void Main(string[] args)
        {
            Console.Write("n= ");
            double sum = 0;
            int n = System.Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(x[i] % 2 != 0)
                {
                    sum += x[i] / fact(i);
                }
            }

            Console.WriteLine(sum);



        }
    }
}