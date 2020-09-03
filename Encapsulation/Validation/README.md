1.
## Validation of Data

**NOTE** : You need a public **StartUp** class with the namespace **PersonsInfo**.

Expand **Person** with proper **validation** for every **field** :

- **Name** must be at **least 3 symbols**
- **Age** must **not** be **zero**** or negative**
- **Salary**** can&#39;t **be** less than 460**

Print proper messages to the user:

- **&quot;Age cannot be zero or a negative integer!&quot;**
- **&quot;First name cannot contain fewer than 3 symbols!&quot;**
- **&quot;Last name cannot contain fewer than 3 symbols!&quot;**
- **&quot;Salary cannot be less than 460 leva!&quot;**

Use **ArgumentExeption** with the listed message.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5Asen Ivanov -6 2200B Borisov 57 3333Ventsislav Ivanov 27 600Asen H 44 666.66Boiko Angelov 35 30020 | Age cannot be zero or a negative integer!First name cannot contain fewer than 3 symbols!Last name cannot contain fewer than 3 symbols!Salary cannot be less than 460 leva!Ventsislav Ivanov gets 660.00 leva. |

### Solution

Add validation to all of the setters in **Person**. Validation may look like this or something similar:

| **Person.cs** |
| --- |
| publicdecimal Salary {get{returnthis.salary;}privateset{if (value \&lt; 460){thrownew ArgumentException(&quot;Salary cannot be less than 460 leva!&quot;);}}} |

