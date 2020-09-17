1.
## Shapes

**NOTE** : You need a public **StartUp** class with the namespace **Shapes**.

Build **hierarchy** of **interfaces** and **classes** :

You should be able to use the class like this:

| **StartUp.cs** |
| --- |
| var radius = int.Parse(Console.ReadLine());IDrawable circle = newCircle(radius);
var width = int.Parse(Console.ReadLine());var height = int.Parse(Console.ReadLine());IDrawable rect = newRectangle(width, height);
circle.Draw();rect.Draw(); |

### Examples

| **Input** | **Output** |
| --- | --- |
| 345 | \*\*\*\*\*\*\*\*\* \*\*\*\* \*\*\* \*\*\* \*\*\*\* \*\*\*\*\*\*\*\*\*\*\*\*\*\* \*\* \*\* \*\*\*\*\* |

### Solution

The algorithm for drawing a circle is:

The algorithm for drawing a rectangle is:

