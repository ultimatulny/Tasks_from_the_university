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

            double[][] m = new double[n][]; // Ступенчатый массив 
            double[] New = new double[n];
            for (int i = 0; i < n; i++) // Задание размерности для каждой строки
            {
                m[i] = new double[n];
            }
         
            int len = 0;

            for (int i = 0; i < n; i++) // Заполнение массива
            {
                len = m[i].Length;

                for (int j = 0; j < len; j++)
                {
                    m[i][j] = rand.Next(0, 50);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Текущий массив:");
            Console.WriteLine();
            for (int i = 0; i < n; i++) // Вывод массива
            {
                len = m[i].Length;
                for (int j = 0; j < len; j++)
                {
                    Console.Write(m[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++) // Проверка элементов в каждом столбце
            {
                for (int i = 0; i < n; i++)
                {
                    if (m[j][i] % 2 != 0)
                    {
                        New[i] = j;
                    }

                }
            }

            Console.WriteLine();

            for (int i = 0; i < New.Length; i++) // Массив с индексами 
            {
                Console.Write(New[i] + " ");
            }



        }
    }
}