using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
	class Program
	{
		static void Main(string[] args)
		{

			// 宣告和初始化一個字典
			Dictionary<string, int> ages = new Dictionary<string, int>
			{
				{ "Alice", 30 },
				{ "Bob", 40 }
			};

			// 添加元素
			ages.Add("Charlie", 25);

			// 存取字典元素
			int ageOfAlice = ages["Alice"];

			// 修改字典元素
			ages["Alice"] = 31;

			foreach (var item in ages)
			{
				Console.WriteLine(item);
			}


		}
	}
}
