using System;

namespace BorderControl
{
	public class Citizen
	{
		public string Name { get; private set; }

		public string Age { get; private set; }

		public string ID { get; private set; }

		public Citizen(string name, string age, string id)
		{
			this.Name = name;
			this.Age = age;
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
