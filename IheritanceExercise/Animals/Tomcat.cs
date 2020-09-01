using System;

namespace Animals
{
	public class Tomcat : Cat //male
	{
		public Tomcat(string name, int age)
			: base(name, age, "male")
		{
		}

		public override string ToString()
		{
			return "MEOW";
		}
	}
}
