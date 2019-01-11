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

            for (int i = 0; i < n; i++) // Задание размерности для каждой строки
            {
                int x = Convert.ToInt32(Console.ReadLine());
                m[i] = new double[x];
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

            int top = 2;
            int bot = 8;
            
            for (int i = 0; i < 3; i++) // Меняем местами строки между 2 и 10
            {
                double[] time = new double[m[top].Length];
                time = m[top];
                m[top] = m[bot];
                m[bot] = time;
                top++;
                bot--;
            }

            Console.WriteLine();
            Console.WriteLine("Новый массив:");
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


        }
    }
}