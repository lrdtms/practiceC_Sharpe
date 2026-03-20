// See https://aka.ms/new-console-template for more information

// string first = "Hello";
// string second = "World";
// string result = string.Format("{1} {0}!", second, first);
// Console.WriteLine(result);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},\nAs a customer of out {currentProduct} Offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N3} shares at a return of {currentReturn:P2}\n\nOur new product, {newProduct} offers a reutrun of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += $"{currentProduct.PadRight(12)}{currentReturn.PadLeft(7)}";

Console.WriteLine(comparisonMessage);