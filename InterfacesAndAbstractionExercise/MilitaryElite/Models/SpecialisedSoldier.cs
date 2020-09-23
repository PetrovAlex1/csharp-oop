namespace MilitaryElite
{
	public class SpecialisedSoldier : Private
	{
		public Corp Corp { get; private set; }

		public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corp) 
			: base(id, firstName, lastName, salary)
		{
			if (nameof(Corp.Airforces) == corp)
			{
				Corp = Corp.Airforces;
			}
			else
			{
				Corp = Corp.Marines;
			}
		}
	}
}
