using System;
using System.Linq;

namespace Telephony
{
	public class StationaryPhone : ICallable
	{
		private bool dataIsCorrect = true;

		public string Number { get; private set; }

		public StationaryPhone(string number)
		{
			var containsLetter = number.Any(x => char.IsLetter(x));

			if (!containsLetter)
			{
				this.Number = number;
			}
			else
			{
				Console.WriteLine("Invalid number!");
				dataIsCorrect = false;
			}
		}

		public void DialingPhone()
		{
			if (dataIsCorrect)
			{
				Console.WriteLine($"Dialing... {this.Number}");
			}
		}
	}
}
