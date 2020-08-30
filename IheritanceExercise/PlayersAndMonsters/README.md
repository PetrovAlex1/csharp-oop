1.
## Players and Monsters

NOTE: You need a public class **StartUp**.

Your task is to create the following game hierarchy:

Create a class Hero. It should contain the following members:

- A constructor, which accepts:
  - **username – string**
  - **level – int**
- The following properties:
  - **Username - string**
  - **Level – int**
- **ToString()** method

Hint: Override **ToString()** of the base class in the following way:

|
 |
| --- |
| publicoverridestring ToString(){return$&quot;Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}&quot;;} |

