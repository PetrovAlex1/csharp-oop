using System;

namespace FootballTeamGenerator
{
	public static class CommonException
	{
		public static void InvalidName()
		{
			Console.WriteLine("A name should not be empty.");
		}

		public static void InvalidRangeStat(string statName)
		{
			Console.WriteLine($"{statName} should be between 0 and 100.");
		}

		public static void InvalidRemoving(string playerName, string teamName)
		{
			Console.WriteLine($"Player {playerName} is not in {teamName} team.");
		}

		public static void MissingTeam(string teamName)
		{
			Console.WriteLine($"Team {teamName} does not exist.");
		}
	}
}
