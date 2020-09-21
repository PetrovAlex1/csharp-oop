namespace FoodShortage
{
	public class Citizen : IBuyer
	{

		public string Name { get; private set; }

		public string Age { get; private set; }

		public string ID { get; private set; }

		public string Birthdate { get; private set; }

		public int Food { get; private set; } = 0;

		public Citizen(string name, string age, string id, string birthdate)
		{
			this.Name = name;
			this.Age = age;
			this.ID = id;
			this.Birthdate = birthdate;
		}

		public bool CheckBirthdate(string birthYearToCheck)
		{
			var areEqual = false;
			var birthYear = string.Empty;

			for (int i = this.Birthdate.Length - birthYearToCheck.Length; i < this.Birthdate.Length; i++)
			{
				birthYear += this.Birthdate[i];
			}

			if (birthYear == birthYearToCheck)
			{
				areEqual = true;
			}

			return areEqual;
		}

	

		public void BuyFood()
		{
			this.Food += 10;
		}
	}
}
