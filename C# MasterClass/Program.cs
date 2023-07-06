// See https://aka.ms/new-console-template for more information

//Datatypes int,Float,Double

// declaring multiple variables at once

using System.Globalization;
using System.Runtime.CompilerServices;

int num3, num4, num5;

// declaring a variable 

int num1;

// assigning a value to variable

num1= 15;

// declaring  and initializing a variable in one go

int num2 = 23;

num2 = 100;

// using concatination

Console.WriteLine("num1 is : " + num1);
int sum = num1 + num2;
Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

double d1 = 3.1415;
double d2 = 5.1;

double dDiv = d1 / d2;
Console.WriteLine("d1/d2 is " + dDiv);

float f1 = 3.1415f;
float f2 = 5.1f;

float fDiv = f1 / f2;
Console.WriteLine("f1/f2 is " + fDiv);

double diDiv = d1 / num1;
Console.WriteLine("d1/num1 is " + diDiv);

// Datatype String 

string myName = "Ilija";

string message = "My Name is " + myName;

string capsMessage =  message.ToUpper();

string lowerCaseMeassge = message.ToLower();

Console.WriteLine("My name is " + myName);
Console.WriteLine(message);
Console.WriteLine(capsMessage);
Console.WriteLine(lowerCaseMeassge);

// Implicit and Explicit Conversion 

// Implicit conversion

int num = 123654528;
long bigNum = num;

float myFloat = 13.37F;
double myNewDouble = myFloat;


double MyDouble = 13.37;
int myInt;

// Explicit Conversion
// cast double to int

myInt = (int)MyDouble;

// type Conversion

string myString = MyDouble.ToString();
string myFloatString = myFloat.ToString();

bool sunIsShining = false;

string myBoolString = sunIsShining.ToString();

Console.WriteLine(myString);
Console.WriteLine(myBoolString);
Console.WriteLine(myFloatString);
Console.WriteLine(myInt);

// Parsing a string to an integer

string myNumString = "15";
string mySecondNumString = "13";
int myNum1  = int.Parse(myNumString);
int myNum2 = int.Parse(mySecondNumString);
int result = myNum1+ myNum2;
Console.WriteLine(result);

// String Manipulation

int age = 33;
string name = "Ilija";
string job = "Developer";

// 1.String Concatenation
Console.WriteLine("String Concatenation");
Console.WriteLine("Hello,my name is " + name + " , I am " + age + " years old.");

//2. String Formating uses index

Console.WriteLine("String formating");
Console.WriteLine("Hello, my name is {0} , I am {1} years old. I'm a {2}.",name,age,job);

//3. String interpolation

Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello,my name is {name}, I am {age} years old.I am {job}.");


// Escape character

string s1 = "this is a \"string\" with \na backslash \\ and a colon";
Console.WriteLine(s1);


// Challenge 01
// Declare a string variable and don’t assign any value to it.Print on the console “Please enter your name and press enter”.
// The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line.  In the third line, it writes on the console the string with no trailing or preceding white space.

string myNameExample ;
Console.WriteLine("Please enter your name and press enter : ");
myName = Console.ReadLine();
string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
string myNamelowerCase = String.Format("Lower case : {0}", myName.ToLower());
string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
string myNameSubstring = String.Format("Substring value : {0}", myName.Substring(0,5));

Console.WriteLine(myNameUpperCase);
Console.WriteLine(myNamelowerCase);
Console.WriteLine(myNameTrimmed);
Console.WriteLine(myNameSubstring);

// Challenge 02

// This application asks the user to input a string in the first line like “Enter a string here: ”.
// In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”
//On the third line, it should write the index of the first occurrence of the searched character from the string.

Console.Write("Enter the string here : ");
string input  = Console.ReadLine();

Console.Write("Enter a Character to search : ");
char searchInput = Console.ReadLine()[0];
int searchIndex = input.IndexOf(searchInput);
Console.WriteLine("Index of character {0} in string is {1}",searchInput,searchIndex);

// Challenge 03

Console.WriteLine("Enter the first name : ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter the last name : ");
string lastName = Console.ReadLine();

// Concatinate to full name

string fullName = string.Concat(firstName," " , lastName);
Console.WriteLine($"Your full name is {fullName}");

Console.ReadLine();