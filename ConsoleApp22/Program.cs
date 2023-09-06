using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[5] { 1, 2, 3, 4, 5 };


			int firstNumber = numbers[0];  // firstNumber = 1

			numbers[0] = 6;

			foreach (var item in numbers)
			{
				Console.WriteLine(item);
			}
		}
	}
}
