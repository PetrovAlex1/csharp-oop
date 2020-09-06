using System.Collections.Generic;
using System;

namespace ShoppingSpree
{
	public class Person
	{
		private string name;
		private decimal money;
		private List<string> bagOfProducts = new List<string>();

		public Person(string name, decimal money)
		{
			this.Name = name;
			this.Money = money;
		}

		public string Name
		{
			get
			{
				return this.name; ;
			}
			private set
			{
				if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
				{
					CommonException.InvalidName();
					Environment.Exit(0);
				}

				this.name = value;
			}
		}

		public decimal Money
		{
			get
			{
				return this.money;
			}
			private set
			{
				if (value < 0)
				{
					CommonException.InvalidMoney();
					Environment.Exit(0);
				}

				this.money = value;
			}
		}

		public void BuyProduct(Product product)
		{
			if (this.money - product.Cost >= 0)
			{
				this.money -= product.Cost;
				bagOfProducts.Add(product.Name);
				Console.WriteLine($"{this.Name} bought {product.Name}");
			}
			else
			{
				Console.WriteLine($"{this.Name} can't afford {product.Name}");
			}
		}

		public string PrintInformation()
		{
			if (this.bagOfProducts.Count > 0)
			{
				return $"{this.Name} - {string.Join(", ", bagOfProducts)}";
			}
			else
			{
				return $"{this.Name} - Nothing bought";
			}
		}
	}
}
