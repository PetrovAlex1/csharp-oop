1.
## Animals

NOTE: You need a public class **StartUp**.

Create a hierarchy of **Animals**. Your program should have three different animals – **Dog** , **Frog** and **Cat**. Deeper in the hierarchy you should have two additional classes – **Kitten** and **Tomcat**. **Kittens are female and Tomcats are male.** All types of animals should be able to produce some kind of sound - **ProduceSound()**. For example, the dog should be able to bark. Your task is to model the hierarchy and test its functionality. Create an animal of each kind and make them all produce sound.

You will be given some lines of input. Each two lines will represent an animal. On the first line will be the type of animal and on the second – the name, the age and the gender. When the command &quot; **Beast!**&quot; is given, stop the input and print all the animals in the format shown below.

### Output

- Print the information for each animal on three lines. On the first line, print: **&quot;{AnimalType}&quot;**
- On the second line print: **&quot;{Name} {Age} {Gender}&quot;**
- On the third line print the sounds it produces: **&quot;{ProduceSound()}&quot;**

### Constraints

- Each **Animal** should have a **name** , an **age** and a **gender**
- **All** input values should **not be blank** (e.g. name, age and so on…)
- If you receive an input for the **gender** of a **Tomcat** or a **Kitten** , ignore it but **create** the animal
- If the input is invalid for one of the properties, throw an exception with message: **&quot;Invalid input!&quot;**
- Each animal should have the functionality to **ProduceSound()**
- Here is the type of sound each animal should produce:
  - **Dog: &quot;Woof!&quot;**
  - **Cat: &quot;Meow meow&quot;**
  - **Frog: &quot;Ribbit&quot;**
  - **Kittens: &quot;Meow&quot;**
  - **Tomcat: &quot;MEOW&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| CatTom 12 MaleDogSharo 132 MaleBeast! | Cat Tom 12 MaleMeow meowDog Sharo 132 MaleWoof! |
| FrogKermit 12 MaleBeast! | Frog Kermit 12 MaleRibbit |
| FrogSashko -2 MaleFrogSashko 2 MaleBeast! | Invalid input!FrogSashko 2 MaleRibbit |

![](RackMultipart20200830-4-1ix51hh_html_63c6245aa4940ad8.gif) ![](RackMultipart20200830-4-1ix51hh_html_5f0f2ddacbac70d2.gif) ![](RackMultipart20200830-4-1ix51hh_html_51bd00be29b85496.gif) ![](RackMultipart20200830-4-1ix51hh_html_f746d52952cd7e91.gif)[![](RackMultipart20200830-4-1ix51hh_html_3aa486326bfa75e9.png)](https://softuni.org/)