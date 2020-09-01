namespace NeedForSpeed
{
	public class SportCar : Car
	{
		public SportCar(int horsepower, double fuel)
				: base(horsepower, fuel)
		{

		}

		public double DefaultFuelConsumption { get; } = 10;
	}
}
