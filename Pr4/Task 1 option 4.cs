using System;

namespace Limerence
{
    class Program
    {

        public static double fact(double f)
        {
            double fa = 1;
            for (int i = 1; i <= f; i++)
            {
                fa *= i;
            }
            return fa;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter E = ");
            double e = System.Convert.ToDouble(Console.ReadLine());
            double j = 1;
            double n = fact(j) / fact(2 * j);
            double sum = 0;

            while (n >= e)
            {
                Console.WriteLine("{0:0.000000000}", n);
                sum += n;
                j++;
                n = fact(j) / fact(2 * j);
            }

            Console.WriteLine("SUM= {0}", sum);
            Console.ReadKey();
        }


    }
}