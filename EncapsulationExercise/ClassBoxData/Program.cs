using System;

namespace ClassBoxData
{
	class Program
	{
		static void Main(string[] args)
		{
			var length = double.Parse(Console.ReadLine());
			var width = double.Parse(Console.ReadLine());
			var height = double.Parse(Console.ReadLine());
			var box = new Box(length, width, height);
			box.PrintInformation();
		}
	}
}
