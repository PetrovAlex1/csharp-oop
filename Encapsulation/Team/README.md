1.
## First and Reserve Team

**NOTE** : You need a public **StartUp** class with the namespace **PersonsInfo**.

Create a **Team** class. Add to this team all of the people you have received. Those who are **younger than 40** go to the **first team** , **others** go to the **reserve team**. At the end print the **sizes of the first** and the **reserved team**.

The class should have **private fields** for:

- **name** : **string**
- **firstTeam** : **List\&lt;Person\&gt;**
- **reserveTeam** : **List\&lt;Person\&gt;**

The class should have **constructors** :

- **Team(string name)**

The class should also have **public**  **properties** for:

- **FirstTeam: List\&lt;Person\&gt; (read only!)**
- **ReserveTeam: List\&lt;Person\&gt; (read only!)**

And a **method** for **adding players** :

- **AddPlayer** ( **Person**** person**):**void**

You should be able to use the class like this:

| **StartUp.cs** |
| --- |
| Team team = new Team(&quot;SoftUni&quot;);
foreach (Person person in persons){team.AddPlayer(person);} |

You should **NOT** be able to use the class like this:

| **StartUp.cs** |
| --- |
| Team team = new Team(&quot;SoftUni&quot;);
foreach (Person person in persons){if(person.Age \&lt; 40){team.FirstTeam.Add(person);}else{team.ReserveTeam(person);}} |

### Examples

| **Input** | **Output** |
| --- | --- |
| 5Asen Ivanov 20 2200Boiko Borisov 57 3333Ventsislav Ivanov 27 600Grigor Dimitrov 25 666.66Boiko Angelov 35 555 | First team has 4 players.Reserve team has 1 players. |

###


### Solution

Add a new class **Team**. Its fields and **constructor** should look like

| **Team.cs** |
| --- |
| privatestring name;private List\&lt;Person\&gt; firstTeam;private List\&lt;Person\&gt; reserveTeam;
publicTeam(string name){this.name = name;this.firstTeam = new List\&lt;Person\&gt;();this.reserveTeam = new List\&lt;Person\&gt;();} |

Properties for **FirstTeam** and **ReserveTeam** have only **getters** :

| **Team.cs** |
| --- |
| public IReadOnlyCollection\&lt;Person\&gt; FirstTeam{get { returnthis.firstTeam.AsReadOnly(); }}
public IReadOnlyCollection\&lt;Person\&gt; ReserveTeam{get { returnthis.reserveTeam.AsReadOnly(); }} |

There will be only **one method** , which **adds players** to teams:

| **Team.cs** |
| --- |
| publicvoid AddPlayer(Person person){if (person.Age \&lt; 40){firstTeam.Add(person);}else{reserveTeam.Add(person);}} |

![](RackMultipart20200903-4-1sh5f6y_html_63c6245aa4940ad8.gif) ![](RackMultipart20200903-4-1sh5f6y_html_5f0f2ddacbac70d2.gif) ![](RackMultipart20200903-4-1sh5f6y_html_51bd00be29b85496.gif) ![](RackMultipart20200903-4-1sh5f6y_html_f746d52952cd7e91.gif)[![](RackMultipart20200903-4-1sh5f6y_html_3aa486326bfa75e9.png)](https://softuni.org/)

