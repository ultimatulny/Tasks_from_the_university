using System;

namespace Mycode
{
    class Program
    {

        public static void Main(string[] args)
        {
            int n = System.Convert.ToInt32(Console.ReadLine()); // Задаем размер массива
            int[] x = new int[n]; // Создаем массив
            int k = 0; // Кол-во ненулевых элементов, стоящих после положительных
            double sum = 0; // Сумма ненулевых элементов, стоящих после положительных
            double result = 0;


            for (int i = 0; i < n; i++) // Заполняем массив
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n-1; i++) // Проверяем элементы
            {
               if((x[i] > 0) && (x[i+1] != 0))
                {
                    sum += x[i + 1];
                    k++;
                }
            }

            result = sum / k;
            Console.WriteLine(result);
        }

    }
}