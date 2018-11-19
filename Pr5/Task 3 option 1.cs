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
            int res = 0;

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Введите {0} элемент ", i);
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(x[i] < 0)
                {
                    check++;
                    res = i;
                    break;
                }
            }

            if(check > 0)
            {
                Console.WriteLine(res);
            }
            else { 
            Console.WriteLine("-1");
            }

        }
    }
}