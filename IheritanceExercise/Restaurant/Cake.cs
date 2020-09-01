namespace Restaurant
{
	public class Cake : Dessert
	{
		public Cake(string name)
			: base(name, 5, 250, 1000)
		{

		}

		private const int grams = 250;
		private const int calories = 1000;
		private const int cakePrice = 5;
	}
}
