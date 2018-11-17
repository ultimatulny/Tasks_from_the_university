using System;


namespace Program
{
    class Program
    {

        static double sum(double m)
        {
            if (m == 1) return 1;
            return m += sum(m - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n= ");
            double n = System.Convert.ToInt32(Console.ReadLine());
            n = sum(n);

            Console.Write("Enter k= ");
            double k = System.Convert.ToInt32(Console.ReadLine());
            k = sum(k*2);

            Console.WriteLine(n + k);


        }
    }
}
