// See https://aka.ms/new-console-template for more information

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string notMyValue = "a";
// Console.WriteLine(notMyValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False
//

//RANDOM COIN FLIP GAME
//______________________________________________________________
// Random coinFlip =  new Random();
// int flip = coinFlip.Next(1, 3);
// string result = flip == 1 ? "Heads" : "Tails";
// Console.WriteLine("Press enter to flip the coin...");
// Console.ReadLine();
// Console.Clear();
// Console.WriteLine(result);
//______________________________________________________________

//CODE CHALLENGE
//_________________________________________________

//What the code needs to do:
//store users name 
//apply permission levels to them 
//have a login where if they type tehir name in they get a message based on their permission

// string permission = "Admin|Manager";
// int level = 55;

// string[] firstName = {"Alice", "Bob", "Charlie"};
// string[] lastName = {"thomas", "williams", "foster"};

// string havePermission = firstName[0] + " " + lastName[0] + " has " + permission + " permissions and is at level " + level;
// string noPermission = firstName[1] + " " + lastName[1] + " does not have permissions and is at level " + level;

// string welcomeMessage = "Welcome, super admin user";

// Console.Write("Enter your name: ");
// string inputName = Console.ReadLine();
// Console.Clear();
// Console.Write("Enter Your last name: ");
// string inputLastName = Console.ReadLine();
// Console.Clear();

// if (inputName == firstName[0] && inputLastName == lastName[0])
// {
//     Console.WriteLine(havePermission);
//     Console.WriteLine(welcomeMessage);
// }
// else if (inputName == firstName[1] && inputLastName == lastName[1])
// {
//     Console.WriteLine(noPermission);
// }
// else
// {
//     Console.WriteLine("User not found.");
// }

string permission = "Admin|Manager";
int level = 55;

bool output = permission.Contains("Admin");

if (output == true && level > 55)
{
    Console.WriteLine("Welcome,Super admin user");
}
else if (output == true && level <= 55)
{
    Console.WriteLine("Welcome, admin user");
}
else if (output == false && level > 20)
{
    Console.WriteLine("Contact an admin for access");
}
else if (output == false && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges");
} 