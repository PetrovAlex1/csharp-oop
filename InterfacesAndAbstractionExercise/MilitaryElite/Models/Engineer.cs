using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
	public class Engineer : SpecialisedSoldier, IEngineer
	{
		public List<Repair> Repairs { get; private set; }

		public Corp corp { get; private set; }

		public Engineer(int id, string firstName, string lastName, decimal salary, string corp)
			:base(id, firstName, lastName, salary, corp)
		{
			this.Repairs = new List<Repair>();
		}

		public void AddRepair(Repair repair)
		{
			this.Repairs.Add(repair);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}");
			sb.AppendLine($"Corps: {this.Corp}");
			sb.Append($"Repairs: ");

			if (this.Repairs.Count != 0)
			{
				foreach (var repair in this.Repairs)
				{
					sb.Append($"\n  {repair.ToString()}");
				}
			}

			return sb.ToString();
		}
	}
}
