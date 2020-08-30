1.
## Need for Speed

NOTE: You need a public class **StartUp**. Create the following **hierarchy** with the following **classes** :

Create a base class **Vehicle**. It should contain the following members:

- A constructor that accepts the following parameters: **int horsePower** , **double fuel**

- **DefaultFuelConsumption**  **– double**
- **FuelConsumption –**  **virtual double**
- **Fuel – double**
- **HorsePower – int**
- **virtual void Drive(double kilometers)**
  - The **Drive** method should have a functionality to reduce the **Fuel** based on the travelled kilometers.

The default fuel consumption for **Vehicle** is **1.25**.Some of the classes have different default fuel consumption values:

- **SportCar –**  **DefaultFuelConsumption = 10**
- **RaceMotorcycle –**  **DefaultFuelConsumption = 8**
- **Car –**  **DefaultFuelConsumption = 3**

Zip your solution without the bin and obj folders and upload it in Judge.

