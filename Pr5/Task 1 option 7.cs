using System;

namespace Mycode
{
    class Program
    {

        public static void Main(string[] args)
        {
            int n = System.Convert.ToInt32(Console.ReadLine()); // Задаем размер массива
            double sum = 0; // Суммирование всех элементов
            double mult = 1; // Перемножение всех элементов
            int[] x = new int[n]; // Создаем массив

            for (int i = 0; i < n; i++) // Заполняем массив
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) // Суммируем все элементы
            {
                sum += x[i];
            }

            for (int i = 0; i < n; i++) // Перемножаем все элементы
            {
                mult *= x[i];
            }

            double result = sum / mult; // находим результат 

            Console.WriteLine(result);

        }

    }
}