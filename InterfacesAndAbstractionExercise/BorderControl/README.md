1.
## Border Control

It&#39;s the future, you&#39;re the ruler of a totalitarian dystopian society inhabited by **citizens** and **robots** , since you&#39;re afraid of rebellions you decide to implement strict control of who enters your city. Your soldiers check the **Id** s of everyone who enters and leaves.

You will receive an unknown amount of lines from the console until the command &quot; **End**&quot; is received, on each line there will be a piece of information for either a citizen or a robot who tries to enter your city in the format: &quot; **{name} {age} {id}**&quot; for **citizens** and &quot; **{model} {id}&quot;** for **robots**. After the end command on the next line you will receive a single number representing **the last digits of fake ids** , all citizens or robots whose **Id** ends with the specified digits must be detained.

The output of your program should consist of all detained **Id** s each on a separate line in the **order** of **input**.

### Input

The input comes from the console. Every commands&#39; parameters before the command &quot; **End**&quot; will be separated by a **single space**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho 22 9010101122MK-13 558833251MK-12 33283122End122 | 901010112233283122
 |
| Toncho 31 7801211340Penka 29 8007181534IV-228 999999Stamat 54 3401018380KKK-666 80808080End340 | 7801211340
 |

