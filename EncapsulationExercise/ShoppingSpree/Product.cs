using System;

namespace ShoppingSpree
{
	public class Product
	{
		private string name;
		private decimal cost;

		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
				{
					CommonException.InvalidName();
				}

				this.name = value;
			}
		}

		public decimal Cost
		{
			get
			{
				return this.cost;
			}
			private set
			{
				if (value < 0)
				{
					CommonException.InvalidMoney();
				}

				this.cost = value;
			}
		}

		public Product(string name, decimal cost)
		{
			this.Name = name;
			this.Cost = cost;
		}
	}
}
