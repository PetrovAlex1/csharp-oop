using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
	public class Commando : SpecialisedSoldier, ICommando
	{
		public List<Mission> Missions { get; private set; }

		public Commando(int id, string firstName, string lastName, decimal salary, string corp)
			:base(id, firstName, lastName, salary, corp)
		{
			this.Missions = new List<Mission>();
		}

		public void AddMission(Mission mission)
		{
			this.Missions.Add(mission);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}");
			sb.AppendLine($"Corps: {this.Corp}");
			sb.Append("Missions:");

			if (this.Missions.Count != 0)
			{
				foreach (var mission in this.Missions)
				{
					if (mission.MissionState == MissionState.inProgress)
					{
						sb.Append($"\n  {mission.ToString()}");
					}
				}
			}

			return sb.ToString();
		}
	}
}
