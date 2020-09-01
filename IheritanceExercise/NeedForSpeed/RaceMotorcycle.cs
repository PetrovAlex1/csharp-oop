namespace NeedForSpeed
{
	public class RaceMotorcycle : Motorcycle
	{
		public RaceMotorcycle(int horsepower, double fuel)
					: base(horsepower, fuel)
		{

		}

		public double DefaultFuelConsumption { get; } = 8;
	}
}
