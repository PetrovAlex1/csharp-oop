using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var listOfRobots = new Dictionary<int, Robot>();
			var listOfCitizens = new Dictionary<int, Citizen>();
			var results = new Dictionary<int, string>();
			var index = 1;

			while (true)
			{
				if (input[0] == "End")
				{
					break;
				}

				if (input.Length == 2)
				{
					var robot = new Robot(input[0], input[1]);
					listOfRobots.Add(index, robot);
					index++;
				}
				else if (input.Length == 3)
				{
					var citizen = new Citizen(input[0], input[1], input[2]);
					listOfCitizens.Add(index, citizen);
					index++;
				}

				input = Console.ReadLine().Split().ToArray();
			}

			var idToCheck = Console.ReadLine();

			foreach (var robot in listOfRobots)
			{
				if (robot.Value.CheckID(idToCheck))
				{
					results.Add(robot.Key, robot.Value.ID);
				}
			}

			foreach (var citizen in listOfCitizens)
			{
				if (citizen.Value.CheckID(idToCheck))
				{
					results.Add(citizen.Key, citizen.Value.ID);
				}
			}

			foreach (var item in results.OrderBy(x => x.Key))
			{
				Console.WriteLine(item.Value);
			}
		}
	}
}
