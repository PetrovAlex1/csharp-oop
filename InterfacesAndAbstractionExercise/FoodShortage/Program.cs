using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var listOfRebels = new List<Rebel>();
			var listOfCitizens = new List<Citizen>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split().ToArray();

				if (input.Length == 4)
				{
					var citizen = new Citizen(input[0], input[1], input[2], input[3]);
					listOfCitizens.Add(citizen);
				}
				else if (input.Length == 3)
				{
					var rebel = new Rebel(input[0], input[1], input[2]);
					listOfRebels.Add(rebel);
				}
			}

			var name = Console.ReadLine();
			var totalFood = 0;

			while (true)
			{
				if (name == "End")
				{
					break;
				}

				foreach (var citizen in listOfCitizens)
				{
					if (citizen.Name == name)
					{
						citizen.BuyFood();
					}
				}
				foreach (var rebel in listOfRebels)
				{
					if (rebel.Name == name)
					{
						rebel.BuyFood();
					}
				}

				name = Console.ReadLine();
			}

			foreach (var citizen in listOfCitizens)
			{
				totalFood += citizen.Food;
			}
			foreach (var rebel in listOfRebels)
			{
				totalFood += rebel.Food;
			}

			Console.WriteLine(totalFood);
		}
	}
}
