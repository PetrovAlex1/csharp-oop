1.
## Hotel Reservation

Create a **static** class **PriceCalculator** that calculates the total price of a holiday, given the **price**** per ****day** , **number**** of ****days** , the **season** and a **discount**** type **.The** discount ****type** and **season** should be **enums**.

You can create a **static class** holding **only one static method** inside. In order to get the **necessary data** for the calculations **inside the class** , you can **pass the data** as an **arguments to the static method**. You are **free** to **implement** any calculation **logic** inside the **method** on the condition that **your output is correct**.

Use your **Main()** method to **read the input** and **print on the console** , but use the **static**** GetTotalPrice() **method in our** static **class** PriceCalculator **in order to** calculate the total price** of the holiday.

The price per day will be multiplied depending on the season by:

- **1** during **Autumn**
- **2** during **Spring**
- **3** during **Winter**
- **4** during **Summer**

The discount is applied to the total price and is one of the following:

- 20% for VIP clients
- 10% for clients, visiting for a second time
- 0% if there is no discount

### Input

On a **single**** line **you will receive all the** information **about the** reservation** in the format:

**&quot;{pricePerDay} {numberOfDays} {season} {discountType}&quot;** , where:

- The price per day will be a valid decimal in the range [0.01…1000.00]
- The number of days will be a valid integer in range [1…1000]
- The season will be one of: **Spring** , **Summer** , **Autumn** , **Winter**
- The discount will be one of: **VIP** , **SecondVisit** , **None** , but it **can** also **be**** omitted** from the input

### Output

On a **single**** line **, print the** total ****price** of the **holiday** , rounded to **2**** digits** after the decimal separator.

### Examples

| **input** | **output** |
| --- | --- |
| 50.25 5 Summer VIP | 804.00 |
| 40 10 Autumn SecondVisit | 360.00 |
| 120.20 2 Winter | 721.20 |

![](RackMultipart20200819-4-fybzvr_html_63c6245aa4940ad8.gif) ![](RackMultipart20200819-4-fybzvr_html_5f0f2ddacbac70d2.gif) ![](RackMultipart20200819-4-fybzvr_html_51bd00be29b85496.gif) ![](RackMultipart20200819-4-fybzvr_html_f746d52952cd7e91.gif)[![](RackMultipart20200819-4-fybzvr_html_3aa486326bfa75e9.png)](https://softuni.org/)

