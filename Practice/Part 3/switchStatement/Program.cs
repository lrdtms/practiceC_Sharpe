// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Enter a fruit name:");

// string fruit = Console.ReadLine();
// switch (fruit)//switch expression, this needs to equal a case for it to execute the code of the case.
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }

// int employeeLevel = 1300;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200 when employeeLevel < 299:
//         title = "Senior Associate";
//         break;
//     case 300:
//     case 400:
//         title = "Manager";
//         break;
//     case 500:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

//Convert to switch statement:
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

string sku = "01-MN-L";
string[] prodcut = sku.Split('-');
string type = "";
string color = "";
string size = "";
switch(prodcut[0])
{
    case "01" :
        type = "sweat shirt";
        break;
    case "02" :
        type = "T-Shirt";
        break;
    case "03" :
        type = "Sweat pants";
        break;
    default :
        type = "Other";
        break;
}

switch(prodcut[1])
{
    case "BL" :
        color = "Black";
        break;
    case "MN" :
        color = "Maroon";
        break;
    default :
        color = "White";
        break;
}

switch(prodcut[2])
{
    case "S" :
        size = "Small";
        break;
    case "M" :
        size = "Medium";
        break;
    case "L" :
        size = "Large";
        break;
    default :
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");