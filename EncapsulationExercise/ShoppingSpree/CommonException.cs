using System;

namespace ShoppingSpree
{
	public static class CommonException
	{
		public static void InvalidName()
		{
			Console.WriteLine("Name cannot be empty");
		}

		public static void InvalidMoney()
		{
			Console.WriteLine("Money cannot be negative");
		}
	}
}
