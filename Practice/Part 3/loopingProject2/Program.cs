// See https://aka.ms/new-console-template for more information
string role = " ";
//string finalRole = " ";
Console.WriteLine("Log In : ");
Console.WriteLine("You need to be a User, Manager or Admin");
do
{
    role += Console.ReadLine();
    role = role.ToLower();
    role = role.Trim(' ');
    Console.WriteLine($"You are signed in as {role} ");
    //break;
}
while (role != "user" && role != "manager" && role != "admin");





