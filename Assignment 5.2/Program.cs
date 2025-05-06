// Assignment 5.2.1
Console.WriteLine("----Assignment 5.2.1----");
string[] arr = { "Hello World", "fly me to the moon" };
foreach (string str in arr)
{
    Console.WriteLine($"The length of the last word in {str} is {AssignmentFunctions.LastWordLength(str)}");
}
Console.WriteLine("\n");


// Assignment 5.2.2
Console.WriteLine("----Assignment 5.2.2----");
Console.Write("Enter the number of numbers to print: ");
int n = Convert.ToInt32(Console.ReadLine());
AssignmentFunctions.RecursiveHeadPrint(n);
Console.WriteLine("\n\n");


// Assignment 5.2.3
Console.WriteLine("----Assignment 5.2.3----");
Console.Write("Enter the number of numbers to print: ");
n = Convert.ToInt32(Console.ReadLine());
AssignmentFunctions.RecursiveTailPrint(n);
Console.WriteLine("\n\n");


// Assignment 5.2.4
Console.WriteLine("----Assignment 5.2.4----");
string[] s = { "RADAR", "Banana", "Anna" };
foreach(string str in s)
{
    if (AssignmentFunctions.RecursivePalindrome(str)) Console.WriteLine($"{str} is a palidrome.");
    else Console.WriteLine($"{str} is not a palindrome.");
}


