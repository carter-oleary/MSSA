// Assignment 7.1.1
Console.WriteLine("----Assignment 7.1.1----");
Random r = new Random();
int n = 20;
int[] grades = new int[n];
for (int i = 0; i < n; i++) grades[i] = r.Next(40, 100);
Console.WriteLine($"Initial array: {Functions.PrintArray(grades)}");
Functions.SelectionSort(grades);
Console.WriteLine($"Sorted array: {Functions.PrintArray(grades)}\n");


// Assignment 7.1.2
Console.WriteLine("----Assignment 7.1.2----");
string s1 = "abc";
string s2 = "pqr";
string s3 = "ab";
string s4 = "pqrs";
string com1 = Functions.MergeStrings(s1, s2);
string com2 = Functions.MergeStrings(s3, s4);
Console.WriteLine($"Word 1: {s1}\nWord 2: {s2}\nCombined: {com1}");
Console.WriteLine($"Word 1: {s3}\nWord 2: {s4}\nCombined: {com2}");


Console.ReadKey();