namespace NeedForSpeed
{
	public class Car : Vehicle
	{
		public Car(int horsepower, double fuel)
			: base(horsepower, fuel)
		{

		}

		public double DefaultFuelConsumption { get; } = 3;
	}
}
