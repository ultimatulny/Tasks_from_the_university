using System;

namespace Program
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            int check = 0;

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(x[i] % 10 == 7)
                {
                    check++;
                }
            }

            if(check == x.Length)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }


        }
    }
}