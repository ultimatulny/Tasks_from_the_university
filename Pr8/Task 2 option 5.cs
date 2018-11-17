using System;


namespace Program
{
    class Program
    {

        static string draw(int i)
        {
            if (i == 0) return "";
            string numbers = i + " " + draw(i - 1);
            Console.WriteLine(numbers);
            return numbers;
        }


        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            draw(n);
        }
    }
}
