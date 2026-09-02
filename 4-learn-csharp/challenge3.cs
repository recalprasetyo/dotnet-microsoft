int fahrenheit = 94;

// double celsius = (fahrenheit - 32) * 5.0 / 9.0;

decimal celsiusDecimal = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine($"The temperature is {celsiusDecimal} Celsius.");
// output: The temperature is 34.44444444444444444444444444 Celsius.

int result = 3 + 1 * 5 / 2;
Console.WriteLine(result); // output: 5

Console.WriteLine(5 / 10); // output: 0

Console.Write("Windows " + 1 + 1); // output: Windows 11