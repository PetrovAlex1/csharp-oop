1.
## Multiple Inheritance

**NOTE** : You need a public **StartUp** class with the namespace **Farm**.

Create three classes named **Animal** , **Dog** and **Puppy** :

- **Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**
- **Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**
- **Puppy** with a single public method **Weep()** that prints: **&quot;weeping…&quot;**
- **Dog** should inherit from **Animal**
- **Puppy** should inherit from **Dog**

| **Sample Main()** |
| --- |
| staticvoid Main(){Puppy puppy = new Puppy();puppy.Eat();puppy.Bark();puppy.Weep();} |

