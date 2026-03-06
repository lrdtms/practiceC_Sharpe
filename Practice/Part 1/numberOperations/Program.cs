// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 23;
int c = a + b;
int d = 20;
int e = c-d;
int f = e*a;
float g = (float)f/b;
string plus = $@"The sum of {a} plus {b} is = {c}";
string minus = $@"{c} minus {d} = {c-d}";
string multiply = @$"{e} times {a} = {e*a}";
string divide = @$"{f} divided by {a} = {f/a}";
string remainder = $@"{a} divided by {g} has a remiander of = {a%g}";
string output = $"{plus}\n{minus}\n{multiply}\n{divide}\n{remainder}";


/*Console.WriteLine(plus);
Console.WriteLine(minus);
Console.WriteLine(multiply); This is the same as this <------
Console.WriteLine(divide);                                  | 
Console.WriteLine(remainder);                               V        
*/
//Console.Write($"{plus}\n{minus}\n{multiply}\n{divide}\n{remainder}");
Console.WriteLine("Math operations:\n");
Console.WriteLine(output + "\n\nThere are 5 different operators being used here.");
Console.WriteLine("\nIncremental operations: \n");

//----------------------------------------------------------------------------------------------------------------------------------------------------
int value = 0;
value = value + 1; // value is now 1
value += 1; // value is now 2
value += 5; // value is now 7
value++; // value is now 8
value *= 2; // value is now 16
value /= 4; // value is now 4
value -= 2; // value is now 2
string incrementProcess = @"int value = 0;
value = value + 1; // value is now 1
value += 1; // value is now 2
value += 5; // value is now 7
value++; // value is now 8
value *= 2; // value is now 16
value /= 4; // value is now 4
value -= 2; // value is now 2";
Console.WriteLine($"{incrementProcess}\n");
Console.WriteLine($@"The value is now : {value}");

//----------------------------------------------------------------------------------------------------------------------------------------------------
//challenge : convert fahrenheit to celsius
float fahrenheit = 100;
float celsius = (fahrenheit - 32) * 5 / 9;
string fahrenheitToCelsius = $@"float fahrenheit = 100;
float celsius = (fahrenheit - 32) * 5 / 9;

The temperature in Celsius is : {celsius}";
Console.WriteLine("Challenge : Convert fahrenheit to celsius\n\n" + fahrenheitToCelsius);
int result = 3 + 1 * 5 / 2;
Console.WriteLine($"\n\nThe result of 3 + 1 * 5 / 2 is : {result}");