using System;
using System.Linq;

namespace HotelReservation
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var pricePerDay = decimal.Parse(input[0]);
			var numberOfDays = int.Parse(input[1]);
			var season = input[2];
			var discountType = input[3];
			var result = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType);
			Console.WriteLine($"{result:F2}");
		}
	}
}
