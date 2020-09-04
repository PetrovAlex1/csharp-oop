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

		private string FirstName
		{
			set
			{
				if (value.Length < 3)
				{
					CommonException.InvalidFirstName();
				}

				this.firstName = value;
			}
		}

		private string LastName
		{
			set
			{
				if (value.Length < 3)
				{
					CommonException.InvalidLastName();
				}

				this.lastName = value;
			}
		}

		public int Age
		{
			get
			{
				return this.age;
			}

			private set
			{
				if (value <= 0)
				{
					CommonException.InvalidAge();
				}

				this.age = value;
			}
		}

		private decimal Salary
		{
			set
			{
				if (value < 460)
				{
					CommonException.InvalidSalary();
				}

				this.salary = value;
			}
		}

		public override string ToString()
		{
			return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";
		}

		public void IncreaseSalary(decimal bonus)
		{
			if (this.age >= 30)
			{
				this.salary += this.salary * bonus / 100;
			}
			else
			{
				this.salary += this.salary * bonus / 200;
			}
		}
	}
}
