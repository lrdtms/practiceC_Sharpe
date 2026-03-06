// See https://aka.ms/new-console-template for more information
/*string name = "";
Console.Write("Enter your name: ");
name += Console.ReadLine();     


Console.WriteLine("Hello, World! I am  " + name);*/

/*Random dice = new Random(); 
int roll = dice.Next(1, 7); //stateful method, it changes the state of the program by generating a random number each time it is called.
Console.WriteLine("You rolled a " + roll); //stateless method, it does not change the state of the program and always returns the same output for the same input.
*/
/*
Random dice = new Random();
string num1 = Console.ReadLine(); //console readline only takes in string input, so we need to parse it to an integer to use it as a parameter for the dice.Next method.
int minVal = int.Parse(num1);
string num2 = Console.ReadLine();
int maxVal = int.Parse(num2);




int roll1 = dice.Next(minVal, maxVal);
Console.WriteLine("You rolled a " + roll1);

Random dice2 = new(); // you dont need to repeat the class name when creating a new instance of a class, you can use the new keyword followed by empty parentheses to create a new instance of the class.
int roll2 = dice2.Next(minVal, maxVal);
Console.WriteLine("You rolled a " + roll2);*/

//code challenge
int firstValue = 500;
int secondValue = 1000;
int maxValue = System.Math.Max(firstValue, secondValue); // this is a static method, it belongs to the class and can be called without creating an instance of the class. It takes two parameters and returns the maximum value of the two parameters.
Console.WriteLine("The maximum value is " + maxValue);