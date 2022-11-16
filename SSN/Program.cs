// See https://aka.ms/new-console-template for more information
using SSN;

Console.WriteLine("Enter The Social Security Number (SSN)");
Validation validation = new();
string ssn = validation.ReadSSN();
validation.ValidateSSN(ssn);
Console.ReadLine();