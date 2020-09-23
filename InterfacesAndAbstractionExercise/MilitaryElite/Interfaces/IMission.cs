namespace MilitaryElite
{
	public interface IMission
	{
		string CodeName { get; }

		MissionState MissionState { get; }
	}
}
