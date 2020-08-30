
1.
## Person

You are asked to model an application for storing data about people. You should be able to have a person and a child. The child derives from the person. Your task is to model the application. The only constraints are:

- People should **not** be able to have a **negative age**
- Children should **not** be able to have an age **more than 15**.

- **Person** – represents the base class by which all of the others are implemented

- **Child** - represents a class, which derives from **Person.**

### Note

Your class&#39;s names **MUST** be the same as the names shown above!!!

| **Sample Main()** |
| --- |
| staticvoid Main(){string name = Console.ReadLine();int age = int.Parse(Console.ReadLine());Child child = newChild(name, age);Console.WriteLine(child);} |

Create a new empty class and name it **Person**. Set its access modifier to **public** so it can be instantiated from any project. Every person has a **name** , and an **age**.

| **Sample Code** |
| --- |
| publicclassPerson{// 1. Add Fields
// 2. Add Constructor
// 3. Add Properties
// 4. Add Methods} |

- Define a **field** for each property the class should have (e.g. **Name** , **Age** )
- Define the **Name** and **Age** properties of a Person.

**Step 1 – Define a Constructor**

Define a constructor that accepts **name and age**.

| **Sample Code** |
| --- |
| public Person(string name, int age){this.Name = name;this.Age = age;} |

**Step 2 – Override ToString()**

As you probably already know, all classes in C# inherit the **Object** class and therefore have all its **public** members ( **T**** oString() **,** E****quals()** and **G**** etHashCode()**methods).**T****oString()** serves to return information about an instance as string. Let&#39;s **override** (change) its behavior for our **Person** class.

| **Sample Code** |
| --- |
| publicoverridestring ToString(){StringBuilder stringBuilder = newStringBuilder();stringBuilder.Append(String.Format(&quot;Name: {0}, Age: {1}&quot;,this.Name,this.Age));
return stringBuilder.ToString();} |

And voila! If everything is correct, we can now create **Person objects** and display information about them.

### Step 3 – Create a Child

Create a **Child** class that inherits **Person** and has the same constructor definition. However, do not copy the code from the Person class - **reuse the**  **Person**  **class&#39; constructor**.

| **Sample Code** |
| --- |
| public Child(string name, int age): base(name, age){} |

There is **no need** to rewrite the **Name** and **Age** properties since **Child** inherits **Person** and by default has them.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho12 | Name: Pesho, Age: 13
 |

