namespace PersonsInfo
{
	public static class CommonException
	{
		public static string InvalidFirstName()
		{
			return "First name cannot contain fewer than 3 symbols!";
		}

		public static string InvalidLastName()
		{
			return "Last name cannot contain fewer than 3 symbols!";
		}

		public static string InvalidAge()
		{
			return "Age cannot be zero or a negative integer!";
		}

		public static string InvalidSalary()
		{
			return "Salary cannot be less than 460 leva!";
		}
	}
}
