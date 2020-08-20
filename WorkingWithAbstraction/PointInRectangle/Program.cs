using System;
using System.Linq;
namespace PointInRectangle
{
	class Program
	{
		static void Main(string[] args)
		{
			var coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var rectangle = new Rectangle(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var currerntCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
				var point = new Point(currerntCoordinates[0], currerntCoordinates[1]);
				var isInside = rectangle.Contains(point);
				Console.WriteLine(isInside);
			}
		}
	}
}
