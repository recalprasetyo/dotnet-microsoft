// string message = $"{greeting} {firstName}!";

string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message1 = $"{updateText} {version}";
Console.WriteLine(message1);

int version1 = 11;
string updateText1 = "Update to Windows";
Console.WriteLine($"{updateText1} {version1}!");

// combine verbatim string literal with string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");