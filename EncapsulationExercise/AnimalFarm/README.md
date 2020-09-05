1.
## Animal Farm

For this problem you have to **download** the provided **skeleton**.

You should be familiar with **encapsulation** already. For this problem, you&#39;ll be working with the **AnimalFarm**  **project**. It contains a class **Chicken**. **Chicken** contains several **fields** , a **constructor** , several **properties** and **methods**. Your task is to **encapsulate** or **hide** anything that is **unintended for viewing** or **modification** from **outside** the class.

### Step 1. Encapsulate Fields

**Fields** should be **private**. Leaving fields open for modification from outside the class is potentially **dangerous**. Make **all fields** in the **Chicken** class **private**. In case the value inside the field is needed elsewhere, use **getters** to reveal it.

### Step 2. Ensure Classes Have a Correct State

Having **getters and setters** is useless, if you don&#39;t actually use them. The **Chicken** constructor **modifies the fields directly** , which is **wrong** when there are suitable **setters** available. **Modify** the constructor to fix this issue.

### Step 3. Validate Data Properly

Validate the chicken&#39;s **name** (it cannot be **null** , **empty** or **whitespace** ). In case of **invalid name** , print Exception message: **&quot;Name cannot be empty.&quot;**.

Validate the **age** properly, **minimum** and **maximum**** age **are provided, make use of them. In case of an** invalid age **, print Exception message:**&quot;Age should be between 0 and 15.&quot; **. Don&#39;t forget to** handle properly **the possibly** thrown Exceptions**.

### Step 4. Hide Internal Logic

If a **method** is intended to be used only by **descendant** classes or **internally** to perform some action, there is no point in keeping them **public**. The **CalculateProductPerDay()** method is used by the **ProductPerDay** public getter. This means the method can safely be **hidden** inside the **Chicken** class by declaring it **private**.

### Step 5. Submit Code to Judge

Submit your code as a **zip file** in Judge. Zip everything **except** the **bin** and **obj**** folders **within the project and submit the** single zip file** in judge.

### Examples

| **Input** | **Output** |
| --- | --- |
| Mara10 | Chicken Mara (age 10) can produce 1 eggs per day. |
| Mara17 | Age should be between 0 and 15. |

