namespace MilitaryElite
{
	public class Private : Soldier, IPrivate
	{
		public decimal Salary { get; private set; }

		public Private(int id, string firstName, string lastName, decimal salary)
			:base(id, firstName, lastName)
		{
			this.Salary = salary;
		}

		public override string ToString()
		{
			return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:f2}";
		}
	}
}
