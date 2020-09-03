1.
## Sort Persons by Name and Age

**NOTE** : You need a public **StartUp** class with the namespace **PersonsInfo**.

Create a class **Person** , which should have **public** properties with **private** setters for:

- **FirstName** : **string**
- **LastName** : **string**
- **Age** : **int**
- **ToString()**: **string** - **override**

You should be able to use the class like this:

| **StartUp.cs** |
| --- |
| publicstaticvoid Main(){var lines = int.Parse(Console.ReadLine());var persons = newList\&lt;Person\&gt;();for (int i = 0; i \&lt; lines; i++){var cmdArgs = Console.ReadLine().Split();var person = newPerson(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));persons.Add(person);}
persons.OrderBy(p =\&gt; p.FirstName).ThenBy(p =\&gt; p.Age).ToList().ForEach(p =\&gt; Console.WriteLine(p.ToString()));} |

### Examples

| **Input** | **Output** |
| --- | --- |
| 5Asen Ivanov 65Boiko Borisov 57Ventsislav Ivanov 27Asen Harizanoov 44Boiko Angelov 35 | Asen Harizanoov is 44 years old.Asen Ivanov is 65 years old.Boiko Angelov is 35 years old.Boiko Borisov is 57 years old.Ventsislav Ivanov is 27 years old. |

### Solution

Create a **new class** and ensure **proper naming**. Define the **public** properties:

| **Person.cs** |
| --- |
| publicclassPerson{publicstring FirstName { get; privateset; }
publicstring LastName { get; privateset; }
publicint Age { get; privateset; }} |

Create a constructor for **Person** , which takes 3 parameters **firstName** , **lastName** , **age** :

| **Person.cs** |
| --- |
| publicPerson(string firstName, string lastName, int age){this.FirstName = firstName;this.LastName = lastName;this.Age = age;} |

Override **ToString()** method:

| **Person.cs** |
| --- |
| publicoverridestring ToString(){return$&quot;{this.FirstName}{this.LastName} is {this.Age} years old.&quot;;} |
