using System;

namespace Mycode
{
	class Program
	{	

		public static void Main(string[] args)
		{
			double x,sum = 0, max =0,before=0;
			do{
				x = System.Convert.ToDouble(Console.ReadLine());
				if((x>max)&&(x!=before)){
					sum = 0;
					max = x;
					sum++;
				} else if((x == max) && (x!=0)){
					sum++;	
				}
				before = x;
			} while(x!=0);
			Console.WriteLine("Наибольшее значение принимают: {0} element",sum);
			Console.ReadKey();
		}
		
		
	}
}
