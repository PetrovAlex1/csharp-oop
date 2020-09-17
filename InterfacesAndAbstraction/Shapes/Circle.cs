using System;

namespace Shapes
{
	public class Circle : IDrawable
	{
		private int radius;

		public int Radius
		{
			get => this.radius;
			private set => this.radius = value;
		}

		public Circle(int radius)
		{
			this.Radius = radius;
		}

		public void Draw()
		{
			var rIn = this.radius - 0.4;
			var rOut = this.radius + 0.4;

			for (double y = this.radius; y >= -this.radius; --y)
			{
				for (double x = -this.radius; x < rOut; x += 0.5)
				{
					var value = x * x + y * y;

					if (value >= rIn * rIn && value <= rOut * rOut)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}

				Console.WriteLine();
			}
		}
	}
}
