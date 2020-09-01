using System;

namespace Animals
{
	class Kitten : Cat // female
	{
		public Kitten(string name, int age)
			: base(name, age, "female")
		{
		}

		public override string ToString()
		{
			return "Meow";
		}
	}
}
