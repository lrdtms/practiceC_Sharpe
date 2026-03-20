// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
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

// Array.Clear(pallets, 2, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }
//CHALLENGE
//___________________________________________________
string ?input  = "";
do 
{
    
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Reverse a string");
    Console.WriteLine("2. Order checker");
    input = Console.ReadLine();
    switch  (input)
    {
        case "1":
string pangram = "The quick brown fox jumps over the lazy dog";
String[] words = pangram.Split(' ');
string reversedWords = "";
foreach (String word in words)
{
    string reversedWord = "";
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);
    foreach (char letter in letters)
    {
        reversedWord += letter;
    }    
    reversedWords += reversedWord + " ";
    Array.Clear(letters);
}
Console.WriteLine(reversedWords);

//EXAMPLE:
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

break;
case "2":
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);
for (int i = 0; i < orders.Length; i++)
{
    string order = orders[i];
    char[] orderChars = order.ToCharArray();
    if (orderChars.Length != 4)
    {
        Console.WriteLine($"{order} - Error" );
    }
    else
    {
        Console.WriteLine($"{order} - Valid" );
    }
}
break;
}
} while (input != "exit");