namespace Animals
{
	public class Animal
	{
		public Animal()
		{

		}
		public Animal(string name, int age, string gender)
			:base()
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name { get; set; }
		public int Age { get; set; }

		public string Gender { get; set; }
	}
}
