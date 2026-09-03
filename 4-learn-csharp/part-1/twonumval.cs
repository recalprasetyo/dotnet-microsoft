int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
// output: 19

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// output: Bob sold 7 widgets.

string firstName1 = "Bob";
int widgetsSold1 = 7;
Console.WriteLine(firstName1 + " sold " + widgetsSold1 + 7 + " widgets.");
// output: Bob sold 77 widgets.

string firstName2 = "Bob";
int widgetsSold2 = 7;
Console.WriteLine(firstName2 + " sold " + (widgetsSold2 + 7) + " widgets.");
// output: Bob sold 14 widgets.