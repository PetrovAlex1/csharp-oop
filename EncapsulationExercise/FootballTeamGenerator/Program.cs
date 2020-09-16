using System;
using System.Linq;

namespace FootballTeamGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var teamName = Console.ReadLine().Split(';').ToArray();
			var team = new Team(teamName[1]);
			var command = Console.ReadLine().Split(';').ToArray();

			while (true)
			{
				if (command[0] == "END")
				{
					break;
				}

				switch (command[0])
				{
					case "Add":
						var player = CrreatePlayer(command);
						var teamNameAdd = command[1];
						team.AddPlayer(teamNameAdd, player);
						break;
					case "Remove":
						var teamNameRemove = command[1];
						var playerName = command[2];
						team.RemovePlayer(teamNameRemove, playerName);
						break;
					case "Rating":
						var teamNameRating = command[1];
						team.ShowStats(teamNameRating);
						break;
					default:
						break;
				}

				command = Console.ReadLine().Split(';').ToArray();
			}
		}

		private static Player CrreatePlayer(string[] command)
		{
			var player = new Player(command[2]
											, int.Parse(command[3])
											, int.Parse(command[4])
											, int.Parse(command[5])
											, int.Parse(command[6])
											, int.Parse(command[7]));
			return player;
		}
	}
}
