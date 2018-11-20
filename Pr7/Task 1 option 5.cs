using System;

namespace Limerence
{
    class Program
    {


        public static void Main(string[] args)
        {
            int n = System.Convert.ToInt32(Console.ReadLine());
            if (n < 100)
            {

                int k = 0;
                double[] a = new double[n];
                Random rand = new Random();
                double box = 0;

                for (int i = 0; i < n; i++)
                {
                    a[i] = rand.Next(0, 50);
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine("________________");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            box = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = box;
                            k++;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.WriteLine("Кол-во перестановок = {0}", k);
            }
            else
            {
                Console.WriteLine("N > 100 !");
            }

        }


    }
}