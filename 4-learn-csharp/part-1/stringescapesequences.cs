Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

// Console.WriteLine("Hello "World"!"); // error

Console.WriteLine("Hello \"World\"!");

// Console.WriteLine("c:\source\repos"); // error

Console.WriteLine("c:\\source\\repos");

// using escape sequences to output a backslash and a double quote
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// Using a verbatim string literal to avoid escaping backslashes
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");