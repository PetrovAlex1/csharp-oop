using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
	public class Team
	{
		private string name;
		private List<Player> players;

		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					CommonException.InvalidName();
				}

				this.name = value;
			}
		}

		public Team(string name)
		{
			this.Name = name;
			this.players = new List<Player>();
		}

		public void AddPlayer(string teamName, Player player)
		{
			if (teamName != this.Name)
			{
				CommonException.MissingTeam(teamName);
			}
			else
			{
				if (CheckStats(player))
				{
					this.players.Add(player);
				}
			}
		}

		private bool CheckStats(Player player)
		{
			var isCorrect = true;

			if (player.Dribble < 0 || player.Dribble > 100)
			{
				isCorrect = false;
			}
			else if (player.Endurance < 0 || player.Endurance > 100)
			{
				isCorrect = false;
			}
			else if (player.Passing < 0 || player.Passing > 100)
			{
				isCorrect = false;
			}
			else if (player.Shooting < 0 || player.Shooting > 100)
			{
				isCorrect = false;
			}
			else if (player.Sprint < 0 || player.Sprint > 100)
			{
				isCorrect = false;
			}
			else if (string.IsNullOrEmpty(player.Name) || string.IsNullOrWhiteSpace(player.Name))
			{
				isCorrect = false;
			}

			return isCorrect;
		}

		public void RemovePlayer(string teamName, string playerName)
		{
			if (teamName != this.name)
			{
				CommonException.MissingTeam(teamName);
			}
			else if (!CheckPlayer(players, playerName))
			{
				CommonException.InvalidRemoving(playerName, this.Name);
			}
			else
			{
				var index = FindIndex(players, playerName);
				this.players.RemoveAt(index);
			}
		}

		private int FindIndex(List<Player> players, string playerName)
		{
			int index = 0;

			for (int i = 0; i < players.Count; i++)
			{
				if (players[i].Name == playerName)
				{
					index = i;
				}
			}

			return index;
		}

		private bool CheckPlayer(List<Player> players, string playerName)
		{
			bool exist = false;

			foreach (var player in players)
			{
				if (player.Name == playerName)
				{
					exist = true;
				}
			}

			return exist;
		}

		public void ShowStats(string teamName)
		{
			if (teamName != this.Name)
			{
				CommonException.MissingTeam(teamName);
			}
			else
			{
				Console.WriteLine($"{this.Name} - {this.CalculateRating()}");
			}
		}

		private int CalculateRating()
		{
			var rating = 0.0;

			foreach (var player in players)
			{
				rating += player.SkillLevel();
			}

			rating = rating / players.Count;
			rating = Math.Ceiling(rating);

			if (players.Count == 0)
			{
				rating = 0;
			}

			return (int)rating;
		}
	}
}
