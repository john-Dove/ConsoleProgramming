// See https://aka.ms/new-console-template for more information

// 1. Declare Variable

/*
    Data types
string - words/numbers (Names, license plate)
int - whole numners | double/float - decimal
char - one character ('A' , '7', '%')
*/

string fullName; //camelCase
string HelloWorld;  //PascalCase - first letter of every word is capitalized
int age;

// 2. Allow user input and output
Console.WriteLine("Enter your full name: ");
fullName = Console.ReadLine();

// 3. Print Contents of variables/users's input
Console.WriteLine("Your full name is: ");
Console.WriteLine(fullName);


