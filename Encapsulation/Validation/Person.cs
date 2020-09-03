
using System;

namespace PersonsInfo
{
	public class Person
	{
		private string firstName;
		private string lastName;
		private int age;
		private decimal salary;

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Salary = salary;
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			private set
			{
				if (value.Length < 3)
				{
					Console.WriteLine(CommonException.InvalidFirstName());
				}

				this.firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			private set
			{
				if (value.Length < 3)
				{
					Console.WriteLine(CommonException.InvalidLastName());
				}

				this.lastName = value;
			}
		}

		public int Age
		{
			get
			{
				return this.Age;	
			}
			private set
			{
				if (string.IsNullOrEmpty(value.ToString()) || value < 0)
				{
					Console.WriteLine(CommonException.InvalidAge());
				}

				this.age = value;
			}
		}

		public decimal Salary
		{
			get
			{
				return this.salary;
			}
			private set
			{
				if (value < 460)
				{
					Console.WriteLine(CommonException.InvalidSalary());
				}

				this.salary = value;
			}
		}

		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
		}

		public void IncreaseSalary(decimal percentage)
		{
			var increse = 0;

			if (this.Age >= 30)
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
