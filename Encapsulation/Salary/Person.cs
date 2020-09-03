namespace PersonsInfo
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, decimal salary)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Salary = salary;
		}

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public int Age { get; private set; }

		public decimal Salary { get; private set; }

		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
		}

		public void IncreaseSalary(decimal percentage)
		{
			var increse = 0;

			if (this.Age > 30)
			{
				increse = 100;
			}
			else
			{
				increse = 200;
			}

			Salary += Salary * (percentage / increse);
		}
	}
}
