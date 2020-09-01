namespace NeedForSpeed
{
	public class Vehicle
	{
		public Vehicle(int horsepower, double fuel)
		{
			this.HorsePower = horsepower;
			this.Fuel = fuel;
		}

		public int HorsePower { get; set; }

		public double Fuel { get; set; }

		public virtual double FuelConsumption { get; set; }

		public double DefaultFuelConsumption { get; } = 1.25;

		public virtual void Drive(double kilometers)
		{
			var consumption = kilometers * DefaultFuelConsumption;
			Fuel -= consumption;
		}
	}
}
