namespace HotelReservation
{
	public static class PriceCalculator
	{
		public static decimal GetTotalPrice(decimal pricePerDay, int numberOfDays, string season, string discountType)
		{
			decimal price = 0;
			Season seasonMultyply = Season.None;
			Discount discount = Discount.None;

			switch (season)
			{
				case "Autumn":
					seasonMultyply = Season.Autumn;
					break;
				case "Spring":
					seasonMultyply = Season.Spring;
					break;
				case "Winter":
					seasonMultyply = Season.Winter;
					break;
				case "Summer":
					seasonMultyply = Season.Summer;
					break;
				default:
					break;
			}

			switch (discountType)
			{
				case "VIP":
					discount = Discount.VIP;
					break;
				case "SecondVisit":
					discount = Discount.SecondVisit;
					break;
				default:
					discount = Discount.None;
					break;
			}

			price += price + pricePerDay * numberOfDays * (int)seasonMultyply;
			price -= ((decimal)discount / 100) * price;

			return price;
		}
	}
}
