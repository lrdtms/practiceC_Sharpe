// See https://aka.ms/new-console-template for more information
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length; //Keeps track of the number of values in the array
string myString = ""; //Since we not using a foreach we need to store the individual array values and make it globally availible
int periodLocation = 0; //this stores the value of the location of where the priod is located with the string

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i]; //selects and add the string in the array to mystring
    periodLocation = myString.IndexOf("."); //sets the periodLocation to the value of which the first period is found within the string
    string mySentence; 
    while (periodLocation != -1)//when using index of, the character we are seearching for, if found will display a int value if not it will output a -1
    {
        mySentence = myString.Remove(periodLocation); //.Remove() is used to removed all the characters in the string after periodLocaiton
        myString = myString.Substring(periodLocation + 1); 
        myString = myString.TrimStart(); //both TrimStart and and Substring i sbeing used to reformat mystring so that it can be used again
        periodLocation = myString.IndexOf("."); //periodLocation is reset now that myString i reformatted 
        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();//This code executes if a period is not found in the array value being the second array
    Console.WriteLine(mySentence);
}







































// string[] splitString = mystring.Split('.');
// foreach (string sentence in splitString)
// {
//     Console.WriteLine(sentence);
// }