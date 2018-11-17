using System;

namespace Mycode
{
    class Program
    {

        public static void Main(string[] args)
        {
            int n = System.Convert.ToInt32(Console.ReadLine()); // Задаем размер массива
            int[] x = new int[n]; // Создаем массив
            int check = 0;

            for (int i = 0; i < n; i++) // Заполняем массив
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++) // Проверяем порядок, если все элементы упорядочены по убыванию, то check == n-1
            {
                if (x[i] > x[i+1])
                {
                    check++;
                }
            }

            if (check == n - 1) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

    }
}