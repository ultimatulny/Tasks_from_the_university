using System;

namespace Limerence
{
    class Program
    {


        public static void Main(string[] args)
        {
            int k = 0;
            int[] a = new int[10];


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Введите {0} элемент = ", i);
                a[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 10 == 0)
                {
                    k++;
                }
            }

            if (k == a.Length)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            Console.ReadKey();


        }

    }
}