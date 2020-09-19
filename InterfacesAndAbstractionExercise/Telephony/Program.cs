using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().ToArray();
			var urls = Console.ReadLine().Split().ToArray();

			foreach (var number in numbers)
			{
				if (number.Length == 7)
				{
					var stationaryPhone = new StationaryPhone(number);
					stationaryPhone.DialingPhone();
				}
				else if (number.Length == 10)
				{
					var smartphone = new Smartphone(number);
					smartphone.CallingPhone();
				}
			}
			foreach (var url in urls)
			{
				var smartPhoneURL = new Smartphone(url, "a");
				smartPhoneURL.Browsing();
			}
		}
	}
}
