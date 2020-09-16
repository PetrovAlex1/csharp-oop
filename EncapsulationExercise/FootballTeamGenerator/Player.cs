using System;

namespace FootballTeamGenerator
{
	public class Player
	{
		private string name;
		private int endurance;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;

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

		public int Endurance
		{
			get
			{
				return this.endurance;
			}
			private set
			{
				if (value < 0 || value > 100)
				{
					CommonException.InvalidRangeStat(nameof(Endurance));
				}

				this.endurance = value;
			}
		}

		public int Sprint
		{
			get
			{
				return this.sprint;
			}
			private set
			{
				if (value < 0 || value > 100)
				{
					CommonException.InvalidRangeStat(nameof(Sprint));
				}

				this.sprint = value;
			}
		}

		public int Dribble
		{
			get
			{
				return this.dribble;
			}
			private set
			{
				if (value < 0 || value > 100)
				{
					CommonException.InvalidRangeStat(nameof(Dribble));
				}

				this.dribble = value;
			}
		}

		public int Passing
		{
			get
			{
				return this.passing;
			}
			private set
			{
				if (value < 0 || value > 100)
				{
					CommonException.InvalidRangeStat(nameof(Passing));
				}

				this.passing = value;
			}
		}

		public int Shooting
		{
			get
			{
				return this.shooting;
			}
			private set
			{
				if (value < 0 || value > 100)
				{
					CommonException.InvalidRangeStat(nameof(Shooting));
				}

				this.shooting = value;
			}
		}

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			this.Name = name;
			this.Endurance = endurance;
			this.Sprint = sprint;
			this.Dribble = dribble;
			this.Passing = passing;
			this.Shooting = shooting;
		}

		public double SkillLevel()
		{
			double sum = (this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / 5.0;

			return sum;
		}
	}
}
