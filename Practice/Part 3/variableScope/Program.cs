// See https://aka.ms/new-console-template for more information
// bool flag = true;
// int value = 10;
// if (flag)
// {
    
//     Console.WriteLine($"Inside the code block: {value}");
// }
// Console.WriteLine(value);
//THIS:
// bool flag = true;
// if (flag)
// {
//     Console.WriteLine(flag);
// }
//CAN BE WRITTEN AS THIS :
// bool flag = true;
// if (flag) Console.WriteLine(flag);
//CODING CHALLENGE:
// GIVEN CODE :
/*int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");*/
//EXPECTED OUTPUT:
//Set contains 42
//Total: 108
//CHANGES:
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}
if (found) Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");
