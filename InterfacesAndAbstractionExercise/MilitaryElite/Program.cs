using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().ToArray();
			var resultMessages = new List<string>();
			var privatesList = new List<Private>();

			while (true)
			{
				if (input[0] == "End")
				{
					break;
				}

				switch (input[0])
				{
					case "Private":
						CreatePrivate(input, resultMessages, privatesList);
						break;
					case "Spy":
						CreateSpy(input, resultMessages);
						break;
					case "LieutenantGeneral":
						CreateLieutenantGeneral(input, resultMessages, privatesList);
						break;
					case "Engineer":
						if (input[5] == nameof(Corp.Airforces) || input[5] == nameof(Corp.Marines))
						{
							CreateEngineer(input, resultMessages);
						}
						break;
					case "Commando":
						if (input[5] == nameof(Corp.Airforces) || input[5] == nameof(Corp.Marines))
						{
							CreateCommando(input, resultMessages);
						}
						break;
					default:
						break;
				}

				input = Console.ReadLine().Split().ToArray();
			}

			foreach (var message in resultMessages)
			{
				Console.WriteLine(message);
			}
		}

		private static void CreateCommando(string[] input, List<string> resultMessages)
		{
			var commando = new Commando(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]), input[5]);

			if (input.Length - 1 > 5)
			{
				for (int i = 6; i <= input.Length - 1; i += 2)
				{
					var currentMission = new Mission(input[i], input[i + 1]);
					commando.AddMission(currentMission);
				}
			}

			resultMessages.Add(commando.ToString());
		}

		private static void CreateEngineer(string[] input, List<string> resultMessages)
		{
			var engineer = new Engineer(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]), input[5]);

			if (input.Length - 1 > 5)
			{
				for (int i = 6; i <= input.Length - 1; i += 2)
				{
					var currentRepair = new Repair(input[i], int.Parse(input[i + 1]));
					engineer.AddRepair(currentRepair);
				}
			}

			resultMessages.Add(engineer.ToString());
		}

		private static void CreateLieutenantGeneral(string[] input, List<string> resultMessages, List<Private> privatesList)
		{
			var lieutenantGeneral = new LieutenantGeneral(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]));

			if (input.Length - 1 > 4)
			{
				for (int i = 5; i <= input.Length - 1; i++)
				{
					var currentId = int.Parse(input[i]);

					foreach (var privates in privatesList)
					{
						if (currentId == privates.ID)
						{
							lieutenantGeneral.AddPrivate(privates);
						}
					}
				}
			}

			resultMessages.Add(lieutenantGeneral.ToString());
		}

		private static void CreateSpy(string[] input, List<string> resultMessages)
		{
			var spy = new Spy(int.Parse(input[1]), input[2], input[3], int.Parse(input[4]));
			resultMessages.Add(spy.ToString());
		}

		private static void CreatePrivate(string[] input, List<string> resultMessages, List<Private> privatesList)
		{
			var privates = new Private(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]));
			resultMessages.Add(privates.ToString());
			privatesList.Add(privates);
		}
	}
}