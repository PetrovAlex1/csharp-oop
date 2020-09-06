using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
	class Program
	{
		static void Main(string[] args)
		{
			var people = Console.ReadLine().Split(';', '=').ToArray();
			var products = Console.ReadLine().Split(';', '=').ToArray();
			var listOfPerson = new Dictionary<string, Person>();
			var listOfProducts = new Dictionary<string, Product>();


			for (int i = 0; i < people.Length; i+=2)
			{
				var currentHumanName = people[i];
				var currentHumanMoney = decimal.Parse(people[i + 1]);
				var person = new Person(currentHumanName, currentHumanMoney);
				listOfPerson.Add(currentHumanName, person);
			}

			for (int i = 0; i < products.Length; i+=2)
			{
				products = products.Where(x => x != string.Empty).ToArray();
				var currentProductName = products[i];
				var currentProductCost = decimal.Parse(products[i + 1]);
				var product = new Product(currentProductName, currentProductCost);
				listOfProducts.Add(currentProductName, product);
			}


			var input = Console.ReadLine().Split().ToArray();

			while (true)
			{
				if (input[0] == "END")
				{
					PrintInformation(listOfPerson);
					break;
				}

				var currentName = input[0];
				var currentProduct = input[1];
				listOfPerson[currentName].BuyProduct(listOfProducts[currentProduct]);
				input = Console.ReadLine().Split().ToArray();
			}
		}

		public static void PrintInformation(Dictionary<string, Person> listOfPerson)
		{
			foreach (var person in listOfPerson)
			{
				Console.WriteLine(person.Value.PrintInformation());
			}
		}
	}
}
