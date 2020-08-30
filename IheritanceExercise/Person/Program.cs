using System;

namespace Person
{
	class Program
	{
		static void Main(string[] args)
		{
			var name = Console.ReadLine();
			var age = int.Parse(Console.ReadLine());

			var child = new Child(name, age);
			Console.WriteLine(child);
		}
	}
}
