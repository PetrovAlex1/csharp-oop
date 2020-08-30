using System.Text;

namespace Person
{
	public class Person
	{
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public int Age
		{
			get
			{
				return this.age;
			}
			set
			{
				this.age = value;
			}
		}

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		private string name;
		private int age;

		public override string ToString()
		{
			var text = new StringBuilder();
			text.Append(string.Format("Name: {0}, Age: {1}", this.Name, this.Age));

			return text.ToString();
		}
	}
}
