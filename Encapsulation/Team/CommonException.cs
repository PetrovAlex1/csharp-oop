using System;

namespace PersonsInfo
{
	public static class CommonException
	{
		public static Exception InvalidFirstName()
		{
			throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
		}

		public static Exception InvalidLastName()
		{
			throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
		}

		public static Exception InvalidAge()
		{
			throw new ArgumentException("Age cannot be zero or a negative integer!");
		}

		public static Exception InvalidSalary()
		{
			throw new ArgumentException("Salary cannot be less than 460 leva!");
		}
	}
}
