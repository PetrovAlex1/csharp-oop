namespace MilitaryElite
{
	public class Spy : Soldier, ISpy
	{
		public int CodeNumber { get; private set; }

		public Spy(int id, string firstName, string lastName, int codeNumber)
			:base(id, firstName, lastName)
		{
			this.CodeNumber = codeNumber;
		}

		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName} Id: {this.ID} \n Code Number: {this.CodeNumber}";
		}
	}
}
