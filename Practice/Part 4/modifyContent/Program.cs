// See https://aka.ms/new-console-template for more information
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
// openingPosition = openingPosition + 1;
// int Length = closingPosition - openingPosition;
// string result = message.Substring(openingPosition, Length);
// Console.WriteLine(result);
//______________________________________________________________________________________________
// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
//____________________________________________________________________________________________________

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
//____________________________________________________________________________________________________
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }
//_______________________-___________________________________________________________________
//CHALLENGE
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string number = input;
int firstNum = number.IndexOf("5");
int lastNum = number.LastIndexOf("0");
int numLength = lastNum - firstNum + 1;

string html = input;
string formatString = html.Replace("<div>", "").Replace("</div>", "").Replace("trade", "reg");

string quantity = $"Quantity: {number.Substring(firstNum, numLength)}";
string output = $"Output: {formatString}";
// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);