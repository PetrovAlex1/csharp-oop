using System.Collections.Generic;
using System;

namespace PizzaCalories
{
	public class Pizza
	{
		private string name;
		private Dough dough;
		private List<Topping> toppings = new List<Topping>();

		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				if (value.Length < 1 || value.Length > 15)
				{
					CommonException.InvalidPizzaName();
					Environment.Exit(0);
				}

				this.name = value;
			}
		}

		public Pizza()
		{

		}

		public Pizza(string name)
		{
			this.Name = name;
		}

		public void AddTopping(Topping topping)
		{
			if (toppings.Count >= 10)
			{
				CommonException.NumberOfToppingsOverflow();
				Environment.Exit(0);
			}

			toppings.Add(topping);
		}

		public void SetPizzaDough(Dough dough)
		{
			this.dough = dough;
		}

		private double SumTotalCalories()
		{
			var totalSum = 0.0;
			totalSum += dough.CalculateCalories();

			foreach (var currentTopping in toppings)
			{
				totalSum += currentTopping.CalculateCalories();
			}

			return totalSum;
		}

		public void PrintInformation()
		{
			Console.WriteLine($"{this.Name} - {SumTotalCalories():F2} Calories.");
		}
	}
}
