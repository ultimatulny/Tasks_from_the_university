using System;


namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            double[,] m = new double[n, n];
            double[] New = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i,j] = rand.Next(0, 50);
                }
            }

            for (int i = 0; i < n; i++) // Вывод массива
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,3}", m[i, j]));
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++) // Проверка элементов в каждом столбце
            {
                for (int i = 0; i < n; i++)
                {
                    if (m[j,i] % 2 != 0)
                    {
                        New[i] = j;
                    }
                    
                }
            }

            Console.WriteLine();

            for (int i = 0; i < New.Length; i++)
            {
                Console.Write(New[i] + " ");
            }

        }
    }
}
