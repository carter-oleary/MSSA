// Assingnment 5.3.1
Console.WriteLine("----Assignment 5.3.1----");
int[] arr = { 1, 0, 0, 0, 1 };
Console.WriteLine(AssignmentFunctions.Flowerbed(arr, 1));
Console.WriteLine(AssignmentFunctions.Flowerbed(arr, 2));

// Assingnment 5.3.2
Console.WriteLine("\n----Assignment 5.3.2----");
arr = [ 2,  3, 5, 7, 10];
foreach (int i in arr)
{
    Console.WriteLine($"There  are {AssignmentFunctions.ClimbStairs(i)} ways to climb {i} stairs.");
}