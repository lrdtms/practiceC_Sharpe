// See https://aka.ms/new-console-template for more information
int val1 = 0;
int val2 = 0;





Console.WriteLine("Select menu option :\n 1. Calculator\n 2. Game \n");

String menu = "";
Console.Write($"Type in your option : ");
menu += Console.ReadLine();

if (menu == "1")
{
    Console.Clear();
    Console.Write("Input first value : ");
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second value : ");
    val2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Select operation :\n 1. Multiply\n 2. Divide\n 3. Add\n 4. Subtract\n");
    Console.Write("Enter your choice : ");
    String operation = "";
    operation += Console.ReadLine();
    if (operation == "1")
    {
        Console.Clear();
        int multiply = val1 * val2;
        Console.WriteLine($"Result: {multiply}");
    }
    else if (operation == "2")
    {
        Console.Clear();
        int divide = val1 / val2;
        Console.WriteLine($"Result: {divide}");
    }
    else if (operation == "3")
    {
        Console.Clear();
        int add = val1 + val2;
        Console.WriteLine($"Result: {add}");
    }
    else if (operation == "4")
    {
        Console.Clear();
        int subtract = val1 - val2;
        Console.WriteLine($"Result: {subtract}");
    }
    else
    {
        Console.WriteLine("Invalid operation selection.");
    }
}  
else if (menu == "2")
{
    
}
else
{
    Console.WriteLine("Invalid menu selection.");
}