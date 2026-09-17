// Code sample 1
// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

// compare code

string name2 = "steve";

if (name2 == "bob")
    Console.WriteLine("Found Bob");
else if (name2 == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");