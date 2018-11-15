using System;

namespace Limerence
{
    class Program
    {
        static double fun(double x)
        {
            if (Math.Abs(x) <= 0.1)
            {
                return Math.Pow(x, 3) - 0.1;
            }
            else if ((Math.Abs(x) > 0.1) && (Math.Abs(x) <= 0.2))
            {
                return (x * 0.2) - 0.1;
            }
            else if (Math.Abs(x) > 0.2)
            {
                return Math.Pow(x, 3) + 0.1;
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
                y = fun(a);
                Console.WriteLine("X = {0}     Y = {1}", a, y);
            }
        }

    }
}