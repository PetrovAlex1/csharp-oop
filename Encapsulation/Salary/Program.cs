using System;
using System.Collections.Generic;

namespace PersonsInfo
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			var lines = int.Parse(Console.ReadLine());
			var persons = new List<Person>();

			for (int i = 0; i < lines; i++)
			{
				var input = Console.ReadLine().Split();
				var person = new Person(input[0],
										input[1],
										int.Parse(input[2]),
										decimal.Parse(input[3]));

				persons.Add(person);
			}

			var parcentage = decimal.Parse(Console.ReadLine());
			persons.ForEach(p => p.IncreaseSalary(parcentage));
			persons.ForEach(p => Console.WriteLine(p.ToString()));
		}
	}
}
