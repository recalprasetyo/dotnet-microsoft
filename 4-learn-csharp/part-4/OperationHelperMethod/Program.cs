// string[] pallets = ["B14", "A11", "B12", "A13"];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
// ehT kciuq nworb xof spmuj revo eht yzal god

pangram = pangram.ToLower();
char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);
string reversedPangram = new string(pangramArray);
Console.WriteLine(reversedPangram);

// string[] message = pangram.Split(' ');
// string[] newMessage = new string[message.Length];
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }
// string result2 = String.Join(" ", newMessage);
// Console.WriteLine(result2);

// In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);
foreach (string orderID in orderIDs)
{
    if (orderID.Length != 4)
    {
        Console.WriteLine($"{orderID} Error");
    }
    else
    {
        Console.WriteLine(orderID);
    }
}
