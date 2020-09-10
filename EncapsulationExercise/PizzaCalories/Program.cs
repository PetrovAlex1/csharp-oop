using System;
using System.Linq;

namespace PizzaCalories
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var pizza = new Pizza();

			while (true)
			{
				if (input[0] == "END")
				{
					pizza.PrintInformation();
					break;
				}

				switch (input[0])
				{
					case "Pizza":
						var pizzaName = input[1];
						pizza = new Pizza(pizzaName);
						break;
					case "Dough":
						var flourType = input[1];
						var bakingTechnique = input[2];
						var doughWeight = double.Parse(input[3]);
						var dough = new Dough(flourType, bakingTechnique, doughWeight);
						pizza.SetPizzaDough(dough);
						break;
					case "Topping":
						var typeOfTopping = input[1];
						var toppingWeight = double.Parse(input[2]);
						var topping = new Topping(typeOfTopping, toppingWeight);
						pizza.AddTopping(topping);
						break;
					default:
						break;
				}

				input = Console.ReadLine().Split().ToArray();
			}
		}
	}
}
