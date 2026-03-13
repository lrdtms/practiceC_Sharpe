// See https://aka.ms/new-console-template for more information

Console.WriteLine("Provide a value between 5 and 10 : ");
while (true)
{
    string inputNumber = Console.ReadLine();
    int number = Convert.ToInt32(inputNumber);
    if (number >= 5 && number <= 10)
    {
        Console.WriteLine($"You entered: {number}");
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a value between 5 and 10.");
    }

};

