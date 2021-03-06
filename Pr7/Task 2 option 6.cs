﻿using System;

namespace ProgramMax
{
    class Program
    {
        static int max(int[,] mass)
        {
            double k = 0; // К - адрес столбца, до которого нужно посчитать, включая его.
            double max = 0; // Максимальное число, относительно которого ищем. Не работает, если все будет меньше нуля

            for (int i = 0; i < mass.GetLength(0); i++) // Сам алгоритм проверки максимального числа в заданной области
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    if(j <= k) // Если столбец меньше или равен нашему К, до которого считаем, то в нем и смотрим макс
                    {
                        if(mass[i,j] > max) // Поиск максимума
                        {
                            max = mass[i, j];
                        }
                    }
                }
                k++; // Увеличиваем с каждой новой строкой К на 1, добиваемся эффекта ступенек.
            }

            for (int i = 0; i < mass.GetLength(0); i++) // вывод алгоритма
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    Console.Write(String.Format("{0,3}", mass[i, j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine("Максимальный элемент в заштрихованной области = {0}", max);
            return 0;
        }

        public static void Main(string[] args)
        {

            Random rand = new Random();
            Console.Write("Введите размерность массива = ");
            int q = System.Convert.ToInt32(Console.ReadLine());

            int[,] Massive = new int[q, q]; 

            for (int i = 0; i < q; i++) // Заполнение массива
            {
                for (int j = 0; j < q; j++)
                {
                    Massive[i, j] = rand.Next(0, 99);
                }
            }

            max(Massive); // вызов метода, который определяет макс и выводит массив
        }



    }
}