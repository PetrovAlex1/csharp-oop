1.
## Shopping Spree

Create two classes: **class**** Person **and** class ****Product**. Each person should have a **name** , **money** and a **bag**** of products **. Each product should have a** name **and a** cost **. Name cannot be an** empty **** string **. Money cannot be a** negative number**.

Create a program in which **each command** corresponds to a **person buying a product**. If the person can **afford** a product, **add** it to his bag. If a person **doesn&#39;t have enough** money, print an **appropriate**** message**(&quot;**{personName} can&#39;t afford {productName}**&quot;).

On the **first two lines** you are given **all people** and **all products**. After all purchases print **every person** in the order of **appearance** and **all products** that he has **bought** also in order of **appearance**. If **nothing was bought** , print the name of the person followed by &quot; **Nothing bought**&quot;.

In case of **invalid input** (negative money Exception message: &quot; **Money cannot be negative**&quot;) or an empty name (empty name Exception message: &quot; **Name cannot be empty**&quot;) **break** the program with an appropriate message. See the examples below:

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho=11;Gosho=4Bread=10;Milk=2;Pesho BreadGosho MilkGosho MilkPesho MilkEND | Pesho bought BreadGosho bought MilkGosho bought MilkPesho can&#39;t afford MilkPesho - BreadGosho - Milk, Milk |
| Mimi=0Kafence=2Mimi KafenceEND | Mimi can&#39;t afford KafenceMimi - Nothing bought |
| Jeko=-3Chushki=1;Jeko ChushkiEND | Money cannot be negative |

