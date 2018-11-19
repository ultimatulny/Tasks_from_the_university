using System;

namespace Program
{
    class Program
    {
        static double function(double x)
        {
            if (Math.Abs(x) <= 1)
            {
                return Math.Pow(x, 2) - 1;
            }
            else if ((Math.Abs(x) > 1) && (Math.Abs(x) <= 2))
            {
                return (2*x) - 1;
            }
            else if (Math.Abs(x) > 2)
            {
                return Math.Pow(x, 5) - 1;
            }
            else return 0;

        }

        public static void Main(string[] args)
        {
            double y = 0;
            Console.Write("a= ");
            double a = System.Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = System.Convert.ToDouble(Console.ReadLine());
            Console.Write("h=");
            double h = System.Convert.ToDouble(Console.ReadLine());

            for (; a <= b; a += h)
            {
                y = function(a);
                Console.WriteLine("X = {0}   Y = {1}", a, y);
            }

        }
    }
}