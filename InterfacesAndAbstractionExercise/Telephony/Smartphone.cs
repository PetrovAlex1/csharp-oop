using System;
using System.Linq;

namespace Telephony
{
	public class Smartphone : ICallable, IBrowsable
	{
		private bool dataIsCorrect = true;

		public string URL { get; private set; }

		public string Number { get; private set; }

		public Smartphone(string url, string number)
		{
			var containsDigits = url.Any(x => char.IsDigit(x));
			var containsWhiteSpaces = string.IsNullOrWhiteSpace(url);

			if (!containsDigits && !containsWhiteSpaces)
			{
				this.URL = url;
			}
			else
			{
				Console.WriteLine("Invalid URL!");
				dataIsCorrect = false;
			}

		}

		public Smartphone(string number)
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

		public void CallingPhone()
		{
			if (dataIsCorrect)
			{
				Console.WriteLine($"Calling... {this.Number}");
			}
		}

		public void Browsing()
		{
			if (dataIsCorrect)
			{
				Console.WriteLine($"Browsing: {this.URL}!");
			}
		}
	}
}
