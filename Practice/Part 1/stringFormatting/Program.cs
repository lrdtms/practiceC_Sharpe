// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, \nWorld!"); //inserts string after the \n on a new line 
Console.WriteLine("Hello, \tWorld!"); //inserts a tab space before the string
Console.WriteLine("Hello, \"World\"!"); //inserts double quotes around the string
Console.WriteLine("Hello, \\World\\!"); //inserts backslashes around the string

Console.WriteLine("Generating emails for customer \"Contorso Corp\" ...\n");
Console.WriteLine("Invoice: 1001\t\t Amount: $2500.00");
Console.WriteLine("Invoice: 1002\t\t Amount: $1500.00");
Console.WriteLine("\nOutput directory: \t");

Console.WriteLine(@"Generating emails for customer ""Contorso Corp"" ...

Invoice: 1001        Amount: $2500.00
Invoice: 1002        Amount: $1500.00

Output directory: ");*/
string verbatimString = @"Generating emails for customer ""Contorso Corp"" ...

Invoice: 1001        Amount: $2500.00
Invoice: 1002        Amount: $1500.00

Output directory: ";
string japDocAddress = @"C:\Users\Contoso\Documents\Invoices\Japanese";
string firstName = "Contoso";
string lastName = "Corp";
string companyName = $"{firstName} {lastName}"; //string interpolation
int e = 1999;
string footer = @"@ " + $@"{companyName} LTD {e}"; //this is a example of string that concatinated with interporlated values
Console.Write(verbatimString + "\t");
Console.WriteLine(@"C:\Users\Contoso\Documents\Invoices
");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\t" + japDocAddress + "\n\n"); //string contatination 
//Console.WriteLine(@"C:\Users\Contoso\Documents\Invoices\Japanese");
//Console.WriteLine(companyName + " " + @$"LTD {e}"); //string interpolation
Console.WriteLine(footer);