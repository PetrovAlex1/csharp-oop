namespace Restaurant
{
	public class Coffee : HotBeverage
	{
		public Coffee(string name, double caffeine)
			: base(name, 3.50m, 50)
		{
			this.Caffeine = caffeine;
		}

		private const double coffeeMilliliters = 50;

		private const decimal coffeePrice = 3.50m;

		public double Caffeine { get; set; }

	}
}
