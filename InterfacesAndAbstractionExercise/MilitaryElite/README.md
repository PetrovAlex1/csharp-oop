1.
## Military Elite

Create the following class hierarchy:

- **Soldier** - general class for **Soldier**** s **, holding** id **,** first name **and** last name ****.**
  - **Private** - lowest base **Soldier** type, holding the **salary** ( **decimal** ).
    - **LieutenantGeneral** - holds a set of **Private**** s** under his command.
    - **SpecialisedSoldier**  **-** general class for all specialised **Soldier**** s **- holds the** corps **of the** Soldier **. The corps can only be one of the following:** Airforces **or** Marines**.
      - **Engineer** - holds a set of **Repair**** s **. A** Repair **holds a** part name **and** hours worked**(**int**).
      - **Commando** - holds a set of **Mission**** s **. A mission holds** code name **and a** state**(**inProgress **or** Finished**). A**Mission **can be finished through the method** CompleteMission()**.
  - **Spy** - holds the **code number** of the **Spy** ( **int** ).

Extract **interfaces** for each class. (e.g. **ISoldier** , **IPrivate** , **ILieutenantGeneral** , etc.) The interfaces should hold their **public** properties and methods (e.g. **ISoldier** should hold **id** , **first name** and **last name** ). Each class should implement its respective interface. **Validate** the **input** where necessary (corps, mission state) - input should match **exactly** one of the **required values** , otherwise it should be treated as **invalid**. In case of **invalid**** corps **the entire line should be skipped, in case of an** invalid ****mission**** state **only the mission should be** skipped**.

You will receive from the console an unknown amount of lines containing information about soldiers until the command &quot; **End**&quot; is received. The information will be in one of the following formats:

- **Private** : &quot; **Private \&lt;id\&gt; \&lt;firstName\&gt; \&lt;lastName\&gt; \&lt;salary\&gt;**&quot;
- **LeutenantGeneral** : &quot; **LieutenantGeneral \&lt;id\&gt; \&lt;firstName\&gt; \&lt;lastName\&gt; \&lt;salary\&gt; \&lt;private1Id\&gt; \&lt;private2Id\&gt; … \&lt;privateNId\&gt;**&quot; where **privateXId** will **always** be an **Id** of a **Private** already received through the input.
- **Engineer** : &quot; **Engineer \&lt;id\&gt; \&lt;firstName\&gt; \&lt;lastName\&gt; \&lt;salary\&gt; \&lt;corps\&gt; \&lt;repair1Part\&gt; \&lt;repair1Hours\&gt; … \&lt;repairNPart\&gt; \&lt;repairNHours\&gt;**&quot; where **repairXPart** is the name of a repaired part and **repairXHours** the hours it took to repair it (the two parameters will always come paired).
- **Commando** : &quot; **Commando \&lt;id\&gt; \&lt;firstName\&gt; \&lt;lastName\&gt; \&lt;salary\&gt; \&lt;corps\&gt; \&lt;mission1CodeName\&gt; \&lt;mission1state\&gt; … \&lt;missionNCodeName\&gt; \&lt;missionNstate\&gt;**&quot; a missions code name, description and state will always come together.
- **Spy** : &quot; **Spy \&lt;id\&gt; \&lt;firstName\&gt; \&lt;lastName\&gt; \&lt;codeNumber\&gt;**&quot;

Define proper constructors. Avoid code duplication through abstraction. Override **ToString()** in all classes to print detailed information about the object.

- **Privates:**
**Name: \&lt;firstName\&gt; \&lt;lastName\&gt; Id: \&lt;id\&gt; Salary: \&lt;salary\&gt;**
- **Spy:**
**Name: \&lt;firstName\&gt; \&lt;lastName\&gt; Id: \&lt;id\&gt;**
**Code Number: \&lt;codeNumber\&gt;**
- **LieutenantGeneral:**
**Name: \&lt;firstName\&gt; \&lt;lastName\&gt; Id: \&lt;id\&gt; Salary: \&lt;salary\&gt;**
**Privates:**
**\&lt;private1 ToString()\&gt;**
**\&lt;private2 ToString()\&gt;**
**…**
**\&lt;privateN ToString()\&gt;**
- **Engineer:**
**Name: \&lt;firstName\&gt; \&lt;lastName\&gt; Id: \&lt;id\&gt; Salary: \&lt;salary\&gt;**
**Corps: \&lt;corps\&gt;**
**Repairs:**
**\&lt;repair1 ToString()\&gt;**
**\&lt;repair2 ToString()\&gt;**
**…**
**\&lt;repairN ToString()\&gt;**
- **Commando:**
**Name: \&lt;firstName\&gt; \&lt;lastName\&gt; Id: \&lt;id\&gt; Salary: \&lt;salary\&gt;**
**Corps: \&lt;corps\&gt;**
**Missions:**
**\&lt;mission1 ToString()\&gt;**
**\&lt;mission2 ToString()\&gt;**
**…**
**\&lt;missionN ToString()\&gt;**
- **Repair:**
**Part Name: \&lt;partName\&gt; Hours Worked: \&lt;hoursWorked\&gt;**
- **Mission:**
**Code Name: \&lt;codeName\&gt; State: \&lt;state\&gt;**

**NOTE:**  **Salary** should be printed rounded to **two decimal places** after the separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| Private 1 Pesho Peshev 22.22
Commando 13 Stamat Stamov 13.1 AirforcesPrivate 222 Toncho Tonchev 80.08LieutenantGeneral 3 Joro Jorev 100 222 1End | Name: Pesho Peshev Id: 1 Salary: 22.22Name: Stamat Stamov Id: 13 Salary: 13.10Corps: AirforcesMissions:Name: Toncho Tonchev Id: 222 Salary: 80.08Name: Joro Jorev Id: 3 Salary: 100.00Privates:Name: Toncho Tonchev Id: 222 Salary: 80.08
Name: Pesho Peshev Id: 1 Salary: 22.22 |
| Engineer 7 Pencho Penchev 12.23 Marines Boat 2 Crane 17Commando 19 Penka Ivanova 150.15 Airforces HairyFoot finished Freedom inProgressEnd | Name: Pencho Penchev Id: 7 Salary: 12.23Corps: MarinesRepairs:Part Name: Boat Hours Worked: 2Part Name: Crane Hours Worked: 17Name: Penka Ivanova Id: 19 Salary: 150.15Corps: Airforces
Missions:Code Name: Freedom State: inProgress |

