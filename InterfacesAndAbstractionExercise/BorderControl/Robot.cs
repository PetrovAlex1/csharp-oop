using System;

namespace BorderControl
{
	public class Robot
	{
		public string Model { get; private set; }

		public string ID { get; private set; }

		public Robot(string model, string id)
		{
			this.Model = model;
			this.ID = id;
		}

		public bool CheckID(string idToCheck)
		{
			var id = this.ID;
			var areEqual = false;
			var lastDigits = string.Empty;

			for (int i = id.Length - idToCheck.Length; i < id.Length; i++)
			{
				lastDigits += id[i];
			}

			if (lastDigits == idToCheck)
			{
				areEqual = true;
			}

			return areEqual;
		}
	}
}
