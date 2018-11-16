using System;

namespace Mycode
{
    class Program
    {

        public static void Main(string[] args)
        {
            double x, sum = 0, max = 0, before = 0;

            x = System.Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Total: {0} element", sum);
                Environment.Exit(0);
            }
            else
            {
                max = x;
                sum++;
               
            }

            do
            {
                x = System.Convert.ToDouble(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Total: {0} element", sum);
                    Environment.Exit(0);
                }
                if (x > max)
                {
                    sum = 0;
                    max = x;
                    sum++;
                } else if(x == max){
                    sum++;
                   
                }
                
            } while (x != 0);
            Console.WriteLine("Total: {0} element", sum);
            Console.ReadKey();
        }

    }
}