using System;
using System.Text;

namespace RhombusOfStars
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			PrintUpperPart(n);
			PrintMiddlePart(n);
			PrintBottomPart(n);
		}
		private static void PrintUpperPart(int n)
		{
			var spaces = n - 1;

			for (int i = 0; i < n - 1; i++)
			{
				var row = new StringBuilder();

				for (int j = 0; j < spaces; j++)
				{
					row.Append(" ");
				}

				for (int l = 0; l <= i; l++)
				{
					row.Append("* ");
				}

				Console.WriteLine(row);
				spaces--;
			}
		}
		private static void PrintMiddlePart(int n)
		{
			var middle = new StringBuilder();

			for (int i = 0; i < n; i++)
			{
				middle.Append("* ");
			}

			Console.WriteLine(middle);
		}

		private static void PrintBottomPart(int n)
		{
			var spaces = 0;

			for (int i = n - 1; i >= 0; i--)
			{
				var row = new StringBuilder();

				for (int j = 0; j <= spaces; j++)
				{
					row.Append(" ");
				}

				for (int l = 0; l < i; l++)
				{
					row.Append("* ");
				}

				Console.WriteLine(row);
				spaces++;
			}
		}
	}
}
