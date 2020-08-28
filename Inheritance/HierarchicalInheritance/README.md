1.
## Hierarchical Inheritance

**NOTE** : You need a public **StartUp** class with the namespace **Farm**.

Create three classes named **Animal** , **Dog** and **Cat** :

- **Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**
- **Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**
- **Cat** with a single public method **Meow()** that prints: **&quot;meowing…&quot;**
- **Dog** and **Cat** should inherit from **Animal**

| **Sample Main()** |
| --- |
| staticvoid Main(){Dog dog = new Dog();dog.Eat();dog.Bark();
Cat cat = new Cat();cat.Eat();cat.Meow();} |

# Part II: Reusing Classes

