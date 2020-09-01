namespace Restaurant
{
	public class Dessert : Food
	{
		public Dessert(string name, decimal price, double grams, double calories)
			: base(name, price, grams)
		{
			this.calories = calories;
		}

		public virtual double calories { get; set; }
	}
}
