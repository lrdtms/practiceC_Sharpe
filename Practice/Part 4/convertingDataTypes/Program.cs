// See https://aka.ms/new-console-template for more information

// string ?value;

// do
// {
// Console.WriteLine("Enter a measurement or type 'exit' to quit:");    
// value = Console.ReadLine();

// int result = 0;
// if (value == "exit")
//     {
//         break;
//     }
//     else{
// string messgae = int.TryParse(value, out result) ? $"Measurement: {result}" : $"Unable to report the measurement. The incorrect input was: {value}";
// Console.WriteLine(messgae);
// }
// } while (true);
//CHALLENGE:
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string arrayPlaceHolder = "";
// decimal total = 0;
// foreach (string value in values)
// {
//     bool valueChecker = decimal.TryParse(value.Replace('.', ','), out decimal result);
//     if (valueChecker == false) {arrayPlaceHolder += value;} total += result;
// }
// Console.WriteLine($"Message: {arrayPlaceHolder}");
// Console.WriteLine($"Total: {total}");
//___________________________________________________________________
//TEST:
// string value = "12,3";
// bool valueChecker = decimal.TryParse(value, out decimal result);
// Console.WriteLine(valueChecker);


int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
decimal sum1 = value1 / value2;
int result1 = (int)Convert.ChangeType(sum1, typeof(int));
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal sum2 = value2 / (decimal)value3;
decimal result2 = sum2;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float sum3 = (float)value3 / value1;
float result3 = sum3;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");