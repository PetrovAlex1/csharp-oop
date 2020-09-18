1.
## Telephony

You have a business - **manufacturing phones**. But you have no software developers, so you call some friends of yours and ask them to help you create a phone software. They have already agreed and you started working on the project. The project consists of two main **models –**  **Smartphone** and **StationaryPhone**. Each of your smartphones should have functionalities of **calling other phones** and **browsing in the world wide web. The**  **StationaryPhone**  **can only call other phones.**

These friends of yours though are very busy, so you decide to write the code on your own. Here is the mandatory assignment:

You should have a **model** - **Smartphone** and two separate functionalities which your **Smartphone** has - to **call other phones** and to **browse in the world wide web**. You should also have a **model** – **StationaryPhone** and one fuctionality which your **StationaryPhone** has – **to call other phones**. You should end up with **two classes** and **two interfaces**.

### Input

The input comes from the console. It will hold two lines:

- **First line** : **phone numbers** to call ( **string** ), separated by spaces.
- **Second line: sites** to visit ( **string** ), separated by spaces.

### Output

- First **call all numbers** in the order of input then **browse all sites** in order of input
- The functionality of calling phones is printing on the console the number which is being called
- If the number is 10 digits long, you are making a call from your smartphone and you print:

**Calling... {number}**

- If the number is 7 digits long, you are making a call from your stationary phone and you print:

**Dialing... {number}**

- The functionality of the browser should print on the console the site in format:

**Browsing: {site}!**

- If there is a number in the input of the URLs, print: **&quot;Invalid URL!&quot;** and continue printing the rest of the URLs.
- If there is a character different from a digit in a number, print: **&quot;Invalid number!&quot;** and continue to the next number.

### Constraints

- Each site&#39;s URL should consist only of letters and symbols ( **No digits are allowed** in the URL address)
- The phone numbers will always be 7 or 10 digits long

### Examples

| **Input** | **Output** |
| --- | --- |
| 0882134215 0882134333 0899213421 0558123 3333123http://softuni.bg http://youtube.com http://www.g00gle.com | Calling... 0882134215Calling... 0882134333Calling... 0899213421Dialing... 0558123Dialing... 3333123Browsing: http://softuni.bg!Browsing: http://youtube.com!Invalid URL! |

