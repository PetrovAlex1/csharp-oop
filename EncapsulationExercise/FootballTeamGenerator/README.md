1.
## \*\*Football Team Generator

A football **Team** has variable **number of players** , a **name** and a **rating**. A **Player** has a **name** and **stats,** which are the basis for his skill level. The stats a player has are **endurance** , **sprint** , **dribble** , **passing** and **shooting**. Each stat can be an **integer** in the range [0..100]. The overall **skill**** level **of a** player **is calculated as the** average **of his** stats **. Only the** name **of a player and his** stats **should be visible to the entire outside world.** Everything ****else** should be **hidden**.

A **Team** should expose a **name** , a **rating** (calculated by the average skill level of all players in the team and **rounded** to the **integer** part only) and **methods** for **adding** and **removing**** players**.

Your task is to **model** the **Team** and the **Player** classes following the proper principles of **Encapsulation**. Expose **only** the properties that need to be visible and **validate**** data** appropriately.

### Input

Your application will receive commands until the &quot; **END**&quot; command is given. The command can be one of the following:

- **&quot;Team;{TeamName}&quot;** - add a new **Team** ;
- **&quot;Add;{TeamName};{PlayerName};{Endurance};{Sprint};{Dribble};{Passing};{Shooting}&quot;** - add a new **Player** to the **Team** ;
- **&quot;Remove;{TeamName};{PlayerName}&quot;** -remove the **Player** from the **Team** ;
- **&quot;Rating;{TeamName}&quot;** - print the **Team** rating, rounded to an integer.

### Data Validation

- A name cannot be null, empty or white space. If not, print **&quot;A name should not be empty.&quot;**
- Stats should be in the range 0..100. If not, print **&quot;[Stat name] should be between 0 and 100.&quot;**
- If you receive a command to remove a missing **Player** , print **&quot;Player [Player name] is not in [Team name] team.&quot;**
- If you receive a command to add a **Player** to a missing **Team** , print **&quot;Team [team name] does not exist.&quot;**
- If you receive a command to show stats for a missing **Team** , print **&quot;Team [team name] does not exist.&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| Team;ArsenalAdd;Arsenal;Kieran\_Gibbs;75;85;84;92;67Add;Arsenal;Aaron\_Ramsey;95;82;82;89;68Remove;Arsenal;Aaron\_RamseyRating;ArsenalEND | Arsenal - 81 |
| Team;ArsenalAdd;Arsenal;Kieran\_Gibbs;75;85;84;92;67Add;Arsenal;Aaron\_Ramsey;195;82;82;89;68Remove;Arsenal;Aaron\_RamseyRating;ArsenalEND | Endurance should be between 0 and 100.Player Aaron\_Ramsey is not in Arsenal team.Arsenal - 81 |
| Team;ArsenalRating;ArsenalEND | Arsenal - 0 |

![](RackMultipart20200905-4-1nj896b_html_63c6245aa4940ad8.gif) ![](RackMultipart20200905-4-1nj896b_html_5f0f2ddacbac70d2.gif) ![](RackMultipart20200905-4-1nj896b_html_51bd00be29b85496.gif) ![](RackMultipart20200905-4-1nj896b_html_f746d52952cd7e91.gif)[![](RackMultipart20200905-4-1nj896b_html_3aa486326bfa75e9.png)](https://softuni.org/)

