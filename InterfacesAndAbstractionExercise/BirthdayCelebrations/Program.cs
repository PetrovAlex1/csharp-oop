using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var listOfCitizens = new Dictionary<int, Citizen>();
			var listOfPets = new Dictionary<int, Pet>();
			var result = new Dictionary<int, string>();
			var index = 1;

			while (true)
			{
				if (input[0] == "End")
				{
					break;
				}

				switch (input[0])
				{
					case "Citizen":
						var citizen = new Citizen(input[1], input[2], input[3], input[4]);
						listOfCitizens.Add(index, citizen);
						index++;
						break;
					case "Pet":
						var pet = new Pet(input[1], input[2]);
						listOfPets.Add(index, pet);
						index++;
						break;
					default:
						break;
				}

				input = Console.ReadLine().Split().ToArray();
			}

			var dateToCheck = Console.ReadLine();

			foreach (var citizen in listOfCitizens)
			{
				if (citizen.Value.CheckBirthdate(dateToCheck))
				{
					result.Add(citizen.Key, citizen.Value.Birthdate);
				}
			}
			foreach (var pet in listOfPets)
			{
				if (pet.Value.CheckBirthdate(dateToCheck))
				{
					result.Add(pet.Key, pet.Value.Birthdate);
				}
			}

			if (result.Count == 0)
			{
				Console.WriteLine();
			}
			else
			{
				foreach (var item in result.OrderBy(x => x.Key))
				{
					Console.WriteLine(item.Value);
				}
			}

		}
	}
}
