namespace MilitaryElite
{
	public class Mission : IMission
	{
		public string CodeName { get; private set; }

		public MissionState MissionState { get; private set; }

		public Mission(string codeName, string state)
		{
			this.CodeName = codeName;

			if (nameof(MissionState.finished) == state)
			{
				MissionState = MissionState.finished;
			}
			else
			{
				MissionState = MissionState.inProgress;
			}
		}

		public void CompleteMission()
		{
			this.MissionState = MissionState.finished;
		}

		public override string ToString()
		{
			return $"Code Name: {this.CodeName} State: {this.MissionState}";
		}
	}
}
