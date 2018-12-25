using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			double x = 0;
			double sum = 0;
			double avg = 0;
			int i = 1;
			bool parsed;


			for (avg = 0; avg <= 90; i++)
			{
				if (i > 1)
				{
					Console.WriteLine("");
					Console.WriteLine("write another one");
				}
				else
					Console.WriteLine("write a number");
				parsed = double.TryParse(Console.ReadLine(), out x);


				if (x <= 100 && parsed)
				{
					sum += x;
					Console.WriteLine("");
					Console.WriteLine("the Average is : " + (avg = sum / i));
				}
				else if ((i >= 1) || ((i >= 1) && (!parsed)))
				{
					Console.WriteLine("write something smaller or equal 100");
					i -= 1;
				}

			}

		}
	}
}

		