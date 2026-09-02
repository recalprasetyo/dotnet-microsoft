string firstName = "John";
int messageCount = 5;
float temperature = 98.6F;

Console.WriteLine("Hello, " + firstName + "! You have " + messageCount + " new messages. The current temperature is " + temperature + " degrees.");

// shortened version using string interpolation
Console.WriteLine($"Hello, {firstName}! You have {messageCount} new messages. The current temperature is {temperature} degrees.");

// string name = "Bob";
// int messages = 3;
// decimal temperature = 34.4m;

// Console.Write("Hello, ");
// Console.Write(name);
// Console.Write("! You have ");
// Console.Write(messages);
// Console.Write(" messages in your inbox. The temperature is ");
// Console.Write(temperature);
// Console.Write(" celsius.");