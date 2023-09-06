using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
	class Program
	{
		static void Main(string[] args)
		{
			// 宣告和初始化一個整數列表
			List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

			// 添加元素
			numbersList.Add(6);

			// 移除元素
			numbersList.Remove(1);

			// 存取列表元素
			int firstListNumber = numbersList[0];

			foreach (var item in numbersList)
			{
				Console.WriteLine(item);
			}

		}
	}
}
