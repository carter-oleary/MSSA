// Assignment 5.4.1
Console.WriteLine("----Assignment 5.4.1----");
int[] arr = [1234, 121, 1999, 15343643];
foreach (int i in arr) {
    Console.Write($"The digits in the number {i} are: ");
    Functions.DisplayDigitsRec(i);
    Console.WriteLine();
}
Console.WriteLine("\n\n");

// Assignment 5.4.2
Console.WriteLine("----Assignment 5.4.2----");
Console.Write("Input the size of the square matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Functions.BuildMatrix(n);
Functions.PrintMatrix(matrix);
Console.WriteLine($"Addition of the right diagonal elements is: {Functions.SumDiagonals(matrix)}");