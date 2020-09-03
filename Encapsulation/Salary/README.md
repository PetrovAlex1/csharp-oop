1.
## Salary Increase

**NOTE** : You need a public **StartUp** class with the namespace **PersonsInfo**. **Refactor the project from the last task.**

Create objects of the class **Person**. Read their **name** , **age** and **salary** from the console. Read the percentage of the bonus to every **Person**** salary **. People younger than** 30 ****get half the increase**. Expand **Person** from the previous task.

New **properties** and **methods:**

- **Salary** : **decimal**
- **IncreaseSalary** ( **decimal**** percentage**)

You should be able to use the class like this:

| **StartUp.cs** |
| --- |
| var lines = int.Parse(Console.ReadLine());var persons = newList\&lt;Person\&gt;();for (int i = 0; i \&lt; lines; i++){var cmdArgs = Console.ReadLine().Split();var person = newPerson(cmdArgs[0], cmdArgs[1],int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
persons.Add(person);}var parcentage = decimal.Parse(Console.ReadLine());persons.ForEach(p =\&gt; p.IncreaseSalary(parcentage));persons.ForEach(p =\&gt; Console.WriteLine(p.ToString())); |

### Examples

| **Input** | **Output** |
| --- | --- |
| 5Asen Ivanov 65 2200Boiko Borisov 57 3333Ventsislav Ivanov 27 600Asen Harizanoov 44 666.66Boiko Angelov 35 559.420 | Asen Ivanov receives 2640.00 leva.Boiko Borisov receives 3999.60 leva.Ventsislav Ivanov receives 660.00 leva.Asen Harizanoov receives 799.99 leva.Boiko Angelov receives 671.28 leva. |

### Solution

Add a new **public** property for **salary** and **refactor the constructor**. Add a new **method** , which will **update**** salary** with a bonus:

| **Person.cs** |
| --- |
| publicvoid IncreaseSalary(decimal percentage){if(this.Age \&gt; 30){this.Salary += this.Salary \* percentage / 100;}else{this.Salary += this.Salary \* percentage / 200;}} |

Refactor the **ToString()** method for this task.

