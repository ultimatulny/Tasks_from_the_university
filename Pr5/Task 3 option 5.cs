using System;

namespace Limerence
{
    class Program
    {
        public static void Main(string[] args)
        {
            int k = 0;
            float sum = 0;
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Введите {0} элемент = ", i);
                a[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 7 == 0) && (a[i] > 0))
                {
                    k++;
                    sum += a[i];
                }
            }

            if (k>0)
            {
                sum = sum / k;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Вы не ввели положительных чисел, кратных 7");
            }

            Console.ReadKey();

        }

    }
}