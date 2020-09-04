using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem
{
	class StudentSystem
	{
		public StudentSystem()
		{
			this.Register = new Dictionary<string, Student>();
		}

		public Dictionary<string, Student> Register { get; set; }

		public void ParseCommand()
		{
			var input = Console.ReadLine().Split().ToArray();

			if (input[0] == "Create")
			{
				CreateStudent(input);
			}
			else if (input[0] == "Show")
			{
				ShowStudent(input);
			}
			else if (input[0] == "Exit")
			{
				Environment.Exit(0);
			}
		}

		private void ShowStudent(string[] input)
		{
			var name = input[1];

			if (Register.ContainsKey(name))
			{
				var student = Register[name];
				var output = $"{student.Name} is {student.Age} years old.";

				if (student.Grade >= 5.00)
				{
					output += " Excellent student.";
				}
				else if (student.Grade < 5.00 && student.Grade >= 3.50)
				{
					output += " Average student.";
				}
				else
				{
					output += " Very nice person.";
				}

				Console.WriteLine(output);
			}
		}

		private void CreateStudent(string[] args)
		{
			var name = args[1];
			var age = int.Parse(args[2]);
			var grade = double.Parse(args[3]);

			if (!Register.ContainsKey(name))
			{
				var student = new Student(name, age, grade);
				Register[name] = student;
			}
		}
	}
}
