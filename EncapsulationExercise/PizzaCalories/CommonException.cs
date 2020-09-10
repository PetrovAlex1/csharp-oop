using System;

namespace PizzaCalories
{
	public static class CommonException
	{
		public static void InvalidDough()
		{
			Console.WriteLine("Invalid type of dough.");
		}

		public static void InvalidWeight()
		{
			Console.WriteLine("Dough weight should be in the range [1..200].");
		}

		public static void InvalidTopping(string invalidTopping)
		{
			Console.WriteLine($"Cannot place {invalidTopping} on top of your pizza.");
		}

		public static void InvalidToppingWeight(string toppingName)
		{
			Console.WriteLine($"{toppingName} weight should be in range [1..50].");
		}

		public static void InvalidPizzaName()
		{
			Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
		}

		public static void NumberOfToppingsOverflow()
		{
			Console.WriteLine("Number of toppings should be in range [0..10].");
		}
	}
}
