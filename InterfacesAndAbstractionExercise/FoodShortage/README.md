1.
## Food Shortage

Your totalitarian dystopian society suffers a shortage of food, so many rebels appear. Extend the code from your previous task with new functionality to solve this task.

Define a class **Rebel** which has a **name** , **age** and **group** ( **string** ) **,** names are **unique -** there will never be 2 **Rebel** s/ **Citizen** s or a **Rebel** and **Citizen** with the same name **.** Define an interface **IBuyer** which defines a method **BuyFood()**and an integer property **Food**. Implement the **IBuyer** interface in the **Citizen** and **Rebel** class, both **Rebel** s and **Citizen** s **start with 0 food** , when a **Rebel** buys food his **Food** increases by **5** , when a **Citizen** buys food his **Food** increases by **10**.

On the first line of the input you will receive an integer **N** - the number of people, on each of the next **N** lines you will receive information in one of the following formats &quot; **\&lt;name\&gt; \&lt;age\&gt; \&lt;id\&gt; \&lt;birthdate\&gt;**&quot; for a **Citizen** or &quot; **\&lt;name\&gt; \&lt;age\&gt;\&lt;group\&gt;**&quot; for a **Rebel**. After the **N** lines until the command &quot; **End**&quot; is received, you will receive names of people who bought food, each on a new line. Note that not all names may be valid, in case of an incorrect name - nothing should happen.

### Output

The **output** consists of only **one line** on which you should print the **total** amount of food purchased.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2Pesho 25 8904041303 04/04/1989Stancho 27 WildMonkeysPeshoGoshoPeshoEnd | 20 |
| 4Stamat 23 TheSwarmToncho 44 7308185527 18/08/1973Joro 31 TerroristsPenka 27 881222212 22/12/1988JirafJo roJirafJoroStamatPenkaEnd | 20 |

