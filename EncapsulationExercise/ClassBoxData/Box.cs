using System;

namespace ClassBoxData
{
	public class Box
	{
		private double length;
		private double width;
		private double height;

		public Box(double length, double width, double height)
		{
			this.Length = length;
			this.Width = width;
			this.Height = height;
		}

		public double Length
		{
			get
			{
				return this.length;
			}
			private set
			{
				if (value <= 0)
				{
					CommonException.InvalidLength();
					Environment.Exit(0);
				}

				this.length = value;
			}
		}

		public double Width
		{
			get
			{
				return this.width;
			}
			private set
			{
				if (value <= 0)
				{
					CommonException.InvalidWidth();
					Environment.Exit(0);
				}

				this.width = value;
			}
		}

		public double Height
		{
			get
			{
				return this.height;
			}
			private set
			{
				if (value <= 0)
				{
					CommonException.InvalidHeight();
					Environment.Exit(0);
				}

				this.height = value;
			}
		}

		private double CalculateSurfaceArea()
		{
			var result = 2 * (length * width + length * height + width * height);

			return result;
		}

		private double CalculateLateralSurfaceArea()
		{
			var result = 2 * (length * height + width * height);

			return result;
		}

		private double CalculateVolume()
		{
			var result = width * length * height;

			return result;
		}

		public void PrintInformation()
		{
			Console.WriteLine($"Surface Area - {CalculateSurfaceArea():F2}");
			Console.WriteLine($"Lateral Surface Area - {CalculateLateralSurfaceArea():F2}");
			Console.WriteLine($"Volume - {CalculateVolume():F2}");
		}
	}
}
