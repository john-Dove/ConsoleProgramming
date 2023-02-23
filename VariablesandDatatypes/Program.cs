// See https://aka.ms/new-console-template for more information

//Varables Declaration and Types
string fullName = string.Empty; // is this the same as saying empty
int age;
double salary;
char gender = char.MinValue;
bool working;

//Prompt User for Input
Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Salary: ");
salary= Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true of false): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print Information
Console.WriteLine("Your name is: ", fullName);  //concatenation
Console.WriteLine("Your Age is: {0}", age);  //
Console.WriteLine($"Your Salary is: {salary}");  //Interpolation
Console.WriteLine($"Your gender is: {gender}");  //interpolation
Console.WriteLine($"You are Employed: {working}");  //interpolation







