namespace PointInRectangle
{
	public class Rectangle
	{
		public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
		{
			TopLeft = new Point(topLeftX, topLeftY);
			BottomRight = new Point(bottomRightX, bottomRightY);
		}

		public Point TopLeft { get; set; }

		public Point BottomRight { get; set; }

		public bool Contains(Point point)
		{
			var XIsInside = (this.TopLeft.X <= point.X) && (point.X <= this.BottomRight.X);
			var YIsInside = (this.TopLeft.Y <= point.Y) && (point.Y <= this.BottomRight.Y);

			return XIsInside && YIsInside;
		}
	}
}
