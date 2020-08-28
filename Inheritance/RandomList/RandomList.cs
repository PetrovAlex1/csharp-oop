using System;
using System.Collections.Generic;

namespace CustomRandomList
{
	public class RandomList : List<string>
	{
		public void RandomString()
		{
			Random random = new Random();
			var index = random.Next(0, this.Count);

			Console.WriteLine(this[index]);

			this.RemoveAt(index);
		}
	}
}
