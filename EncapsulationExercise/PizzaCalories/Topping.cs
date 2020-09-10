using System;

namespace PizzaCalories
{
	public class Topping
	{
		private double weight;
		public const double meat = 1.2;
		public const double veggies = 0.8;
		public const double cheese = 1.1;
		public const double sauce = 0.9;
		private double typeOfTopping = 0.0;
		private string nameTypeOfTopping;

		public double Weight
		{
			get
			{
				return this.weight;
			}
			private set
			{
				if (value < 1 || value > 50)
				{
					CommonException.InvalidToppingWeight(nameTypeOfTopping);
					Environment.Exit(0);
				}

				this.weight = value;
			}
		}

		public Topping(string topping, double weight)
		{
			switch (topping.ToLower())
			{
				case nameof(Topping.cheese):
					typeOfTopping = Topping.cheese;
					nameTypeOfTopping = nameof(Topping.cheese);
					break;
				case nameof(Topping.meat):
					typeOfTopping = Topping.meat;
					nameTypeOfTopping = nameof(Topping.meat);
					break;
				case nameof(Topping.sauce):
					typeOfTopping = Topping.sauce;
					nameTypeOfTopping = nameof(Topping.sauce);
					break;
				case nameof(Topping.veggies):
					typeOfTopping = Topping.veggies;
					nameTypeOfTopping = nameof(Topping.veggies);
					break;
				default:
					break;
			}

			if (this.typeOfTopping == 0.0)
			{
				CommonException.InvalidTopping(topping);
				Environment.Exit(0);
			}

			this.Weight = weight;
		}

		public double CalculateCalories()
		{
			var result = (2 * Weight) * typeOfTopping;

			return result;
		}
	}
}
