using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
	class Program
	{
		static void Main(string[] args)
		{
            // 創建一個 Animal 類型的 List
            List<Animal> animals = new List<Animal>();

            // 添加不同類型的動物到列表
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Bird());

            // 使用迴圈遍歷列表並呼叫每個動物的 MakeSound 方法
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }


        }
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        public class Bird : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Tweet!");
            }
        }
    }
}
