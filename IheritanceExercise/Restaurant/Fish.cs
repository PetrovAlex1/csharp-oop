namespace Restaurant
{
	public class Fish : MainDish
	{
		public Fish(string name, decimal price)
			: base(name, price, 22)
		{

		}

		private const double grams  = 22;
	}
}
