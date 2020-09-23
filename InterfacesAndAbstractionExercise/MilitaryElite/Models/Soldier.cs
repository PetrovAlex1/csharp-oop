namespace MilitaryElite
{
	public class Soldier : ISoldier
	{
		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public int ID { get; private set; }

		public Soldier(int id, string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.ID = id;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
