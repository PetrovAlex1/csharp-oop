namespace BirthdayCelebrations
{
	public class Pet : IBirthable
	{
		public string Name { get; private set; }

		public string Birthdate { get; private set; }

		public Pet(string name, string birthdate)
		{
			this.Name = name;
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
	}
}
