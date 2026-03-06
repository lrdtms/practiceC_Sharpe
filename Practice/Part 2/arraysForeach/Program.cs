    // // See https://aka.ms/new-console-template for more information

    // string[] fraudulentOrderIDs = new string[3]; //arrays start at 0, so the last index is 2
    // fraudulentOrderIDs[0] = "A123";
    // fraudulentOrderIDs[1] = "B456";
    // fraudulentOrderIDs[2] = "C789";

    // //string id1 = null; //variables must be iniatlised with nothing or be set to null if you want to add to them later. If you try to add to an unitialised variable, you will get an error.
    // //id1 += fraudulentOrderIDs[0]; 
    // //string id2 = fraudulentOrderIDs[1];
    // string id3 = fraudulentOrderIDs[2];

    // /*Console.WriteLine($@"Fraudulent ID 1 : {id1}
    // Fraudulent ID 2 : {id2}
    // Fraudulent ID 3 : {id3}");*/
    // int fraudIdTracker = 0;
    // foreach (string fraudulentID in fraudulentOrderIDs) //foreach is a loop that iterates through each element in an array. It is a more concise way to iterate through an array than a for loop. It does not require an index variable, and it automatically iterates through each element in the array.
    // {
    //     fraudIdTracker++;
    //     Console.WriteLine($"Fraudulent ID {fraudIdTracker} : {fraudulentID}");
    // }

    // if (!string.IsNullOrEmpty(id3))
    // {
    //     fraudulentOrderIDs[2] = "F000";
    //     id3 = fraudulentOrderIDs[2];
    //     Console.WriteLine($@"Reassigned ID 3 : {id3}
    //     ");
    // }

    // string[] IDs = [
    //     "A123",
    //     "B456",
    //     "C789"
    // ]; //Short hand for creating and assigning values to an array. The compiler can infer the size of the array from the number of values provided.

    // /*Console.WriteLine($@"ID 1 : {ID[0]}
    // ID 2 : {ID[1]}
    // ID 3 : {ID[2]}");*/

    // int idTracker = 0;
    // foreach (string id in IDs)
    // {
    //     idTracker++;
    //     Console.WriteLine($"ID {idTracker} : {id}");
    // }

    // int numOfFraudID = fraudulentOrderIDs.Length;
    // int numOfID = IDs.Length;
    // int totalIDs = numOfFraudID + numOfID;
    // Console.WriteLine($"All IDs: {totalIDs}"); //Length is a property of arrays that returns the number of elements in the array. It is not a method, so it does not require parentheses.

//CHALLENGE
//____________________________________________________________________________________________

string[] IDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in IDs)
{
    if (id.StartsWith("B"))
    { 
        Console.WriteLine(id);
    }
}