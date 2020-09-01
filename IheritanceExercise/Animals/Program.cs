using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			var animals = new Dictionary<string, Animal>();

			while (true)
			{
				var typeAnimal = Console.ReadLine();

				if (typeAnimal == "Beast!")
				{
					break;
				}

				var information = Console.ReadLine().Split().ToArray();

				if (CheckAge(information))
				{
					Console.WriteLine("Invalid input!");
					continue;
				}

				var animal = CreateAnimal(typeAnimal, information);
				animals.Add(typeAnimal, animal);
			}

			ShowInformation(animals);
		}

		private static bool CheckAge(string[] information)
		{
			var isNegative = false;
			var age = int.Parse(information[1]);

			if (age < 0)
			{
				isNegative = true;
			}
			else if (string.IsNullOrWhiteSpace(information[1]))
			{
				isNegative = true;
			}

			return isNegative;
		}

		private static void ShowInformation(Dictionary<string, Animal> animals)
		{
			foreach (var animal in animals)
			{
				Console.WriteLine(animal.Key);
				Console.WriteLine($"{animal.Value.Name} {animal.Value.Age} {animal.Value.Gender}");
				Console.WriteLine(animal.Value);
			}
		}

		private static Animal CreateAnimal(string typeAnimal, string[] information)
		{
			var animal = new Animal();

			switch (typeAnimal)
			{
				case "Dog":
					animal = new Dog(information[0], int.Parse(information[1]), information[2]);
					break;
				case "Cat":
					animal = new Cat(information[0], int.Parse(information[1]), information[2]);
					break;
				case "Frog":
					animal = new Frog(information[0], int.Parse(information[1]), information[2]);
					break;
				case "Kitten":
					animal = new Kitten(information[0], int.Parse(information[1]));
					break;
				case "Tomcat":
					animal = new Tomcat(information[0], int.Parse(information[1]));
					break;
				default:
					break;
			}

			return animal;
		}
	}
}
