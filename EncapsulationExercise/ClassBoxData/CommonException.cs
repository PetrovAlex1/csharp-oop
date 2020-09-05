using System;

namespace ClassBoxData
{
	public static class CommonException
	{
		public static void InvalidLength()
		{
			Console.WriteLine("Length cannot be zero or negative.");
		}
		public static void InvalidWidth()
		{
			Console.WriteLine("Width cannot be zero or negative.");
		}
		public static void InvalidHeight()
		{
			Console.WriteLine("Height cannot be zero or negative.");
		}
	}
}
