1.
## Point in Rectangle

Create a class **Point** and a class **Rectangle**. The **Point** should hold **coordinates X** and **Y** and the **Rectangle** should hold 2 **Points** – its **top**** left **and** bottom ****right** corners. In the **Rectangle** class, you should implement a **Contains(Point point)** method that returns **true** or **false** , based on **whether** the **Point** given as **attribute** is **inside** or **outside** of the **Rectangle** object. Points **on**** the ****side** of a Square are considered **inside**.

### Input

- On the first line read the **coordinates** of the **top**** left **and** bottom ****right** corner of the **Rectangle** in the format: **&quot;{topLeftX} {topLeftY} {bottomRightX} {bottomRightY}&quot;**.
- On the second line, read an integer **N** and on the next **N** lines, read the **coordinates** of **points**.

### Output

- For each point, print out the result of the **Contains()** method.

### Examples

| **input** | **output** |
 | **input** | **output** |
 | **input** | **output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 0 0 3 350 00 14 45 31 2 | TrueTrueFalseFalseTrue |
 | 2 -3 12 348 -111 31 12 4 | TrueTrueFalseFalse |
 | 5 8 12 1560 05 812 158 157 158 12 | FalseTrueTrueTrueTrueTrue |

