using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
	public class LieutenantGeneral : Private, ILieutenantGeneral
	{
		public List<Private> Privates { get; private set; }

		public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
			:base(id, firstName, lastName, salary)
		{
			this.Privates = new List<Private>();
		}

		public void AddPrivate(Private @private)
		{
			this.Privates.Add(@private);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}");
			sb.Append($"Privates: ");

			if (this.Privates.Count != 0)
			{
				foreach (var privates in Privates)
				{
					sb.Append($"\n  {privates.ToString()}");
				}
			}

			return sb.ToString();
		}
	}
}
