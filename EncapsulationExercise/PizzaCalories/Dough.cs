using System;

namespace PizzaCalories
{
	public class Dough
	{
		private double weight;

		public double FlourType { get; private set; } = 0.0;

		public double BakingTechnique { get; private set; } = 0.0;

		public double Weight
		{
			get
			{
				return this.weight;
			}
			private set
			{
				if (value < 1 || value > 200)
				{
					CommonException.InvalidWeight();
					Environment.Exit(0);
				}

				this.weight = value;
			}
		}

		public Dough(string flourType, string bakingTechnique, double weight)
		{
			switch (flourType.ToLower())
			{
				case nameof(FlourTypes.white):
					FlourType = FlourTypes.white;
					break;
				case nameof(FlourTypes.wholegrain):
					FlourType = FlourTypes.wholegrain;
					break;
				default:
					break;
			}

			switch (bakingTechnique.ToLower())
			{
				case nameof(BakingTechniques.chewy):
					BakingTechnique = BakingTechniques.chewy;
					break;
				case nameof(BakingTechniques.crispy):
					BakingTechnique = BakingTechniques.crispy;
					break;
				case nameof(BakingTechniques.homemade):
					BakingTechnique = BakingTechniques.homemade;
					break;
				default:
					break;
			}

			if (this.FlourType == 0.0 || this.BakingTechnique == 0.0)
			{
				CommonException.InvalidDough();
				Environment.Exit(0);
			}

			this.Weight = weight;
		}

		public double CalculateCalories()
		{
			var result = (2 * weight) * FlourType * BakingTechnique;

			return result;
		}
	}
}
