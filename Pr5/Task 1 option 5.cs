using System;

namespace Limerence
{
    class Program
    {
        public static void Main(string[] args)
        {
            double min = 0;
            double max = 0;
            double elem = 0;
            int n = System.Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i += 2)
            {
                elem = Math.Pow(x[i], i);
                if (elem > max)
                {
                    max = elem;
                }
            }

            min = max;

            for (int i = 0; i < n; i += 2)
            {
                elem = Math.Pow(x[i], i);
                if (elem < min)
                {
                    min = elem;
                }
            }

            Console.WriteLine(min);
        }

    }
}