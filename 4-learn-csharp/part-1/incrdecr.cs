int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.
value--;           // value is now 1.

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value); // output: 2

value += 1;
Console.WriteLine("Second increment: " + value); // output: 3

value++;
Console.WriteLine("Third increment: " + value); // output: 4

value = value - 1;
Console.WriteLine("First decrement: " + value); // output: 3

value -= 1;
Console.WriteLine("Second decrement: " + value); // output: 2

value--;
Console.WriteLine("Third decrement: " + value); // output: 1

int value = 1;
value++;
Console.WriteLine("First: " + value); // output: 2
Console.WriteLine($"Second: {value++}"); // output: 2
Console.WriteLine("Third: " + value); // output: 3
Console.WriteLine("Fourth: " + (++value)); // output: 4