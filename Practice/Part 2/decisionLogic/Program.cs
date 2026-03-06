// See https://aka.ms/new-console-template for more information
/*Random dice = new();
string minVal = Console.ReadLine();
string maxVal = Console.ReadLine();
int minRoll = int.Parse(minVal);
int maxRoll = int.Parse(maxVal);

string lowMessage = "You rolled a low number!";
string highMessage = "You rolled a high number!";

int roll = dice.Next(minRoll, maxRoll);

if (roll <= 10 )
{
    Console.WriteLine(lowMessage);
}
else
{
    Console.WriteLine(highMessage);
}*/

/*Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);    
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
//Console.WriteLine($@"Dice rolls : {roll1}, {roll2}, {roll3}
///Total : {total}"); 
if (total < 12)
{
    Console.WriteLine($"This is your total {total}, its too low! You lose!");
}
if (total > 12)
{
    Console.WriteLine($"This is your total {total}, its high! You win!");
}*/

/*
Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);    
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
bool result = total < 12;
//Console.WriteLine($@"Dice rolls : {roll1}, {roll2}, {roll3}
///Total : {total}"); 
if (result)
{
    Console.WriteLine($"This is your total {total}, its too low! You lose!");
}
if (!result)
{
    string win = $"This is your total {total}, its high! You win!"; //-----
    Console.WriteLine(win);                                         //     | 
    bool winResult = win.Contains("win");                           //     |
    if (winResult)                                                  //     ----------Example of a method that returns a boolean value, and how we can use it in an if statement. The method is Contains, which checks if the string win contains the substring "win". If it does, it returns true, and we print "Congratulations!".
    {                                                               //     |
        Console.WriteLine("Congratulations!");                      //     |
    }                                                               //-----

}
if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("You rolled a double!");
    if (roll1 == roll2)
    {
        Console.WriteLine($"The double is {roll1}");
    }
    else if (roll1 == roll3)
    {
        Console.WriteLine($"The double is {roll1}");
    }
    else
    {
        Console.WriteLine($"The double is {roll2}");
    }
}
*/
//CHALLENGE
//_______________________________________________________________________________________________________________
 Random random = new();
 int daysUntilExpiration = random.Next(12);
 int discountPercentage = 0;

 if (daysUntilExpiration == 10)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days! Renew now and save 10%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days!
    renew now and save 20%!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine(@"Your subscription expires within a day!
    renew now for 20% off!");
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine(@"Your subscription has expired!
    Renew now for 30% off!");
}
else
{
    
}
