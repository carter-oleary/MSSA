// Assignment 6.2.1
Console.WriteLine("----Assignment 6.2.1----");
MyStack<int> stack = new MyStack<int>([0, 1, 2, 3]);
Console.WriteLine(stack.ToString());
Console.WriteLine("Pushing 4...");
stack.Push(4);
Console.WriteLine(stack.ToString());
Console.WriteLine("Popping...");
Console.WriteLine($"Popped value: {stack.Pop()}");
Console.WriteLine(stack.ToString());
Console.WriteLine();

// Assignment 6.2.2
Console.WriteLine("----Assignment 6.2.2----");
int[] arr1 = [1, 2, 3, 4];
int[] arr2 = [-1, 1, 0, -3, 3];
Console.Write("Starting Array: ");
PrintArray(arr1);
Console.Write("Product Array: ");
PrintArray(ArrayProduct(arr1));
Console.Write("Starting Array: ");
PrintArray(arr2);
Console.Write("Product Array: ");
PrintArray(ArrayProduct(arr2));

int[] ArrayProduct(int[] arr)
{
    int[] prodArr = new int[arr.Length]; // Tracks the products of each iteration
    int product = 1; // Total product of the array
    int numZeros = 0; // Number of zeroes in array
    int zeroIndex = -1; // Index of the zero in the array

    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] == 0)
        {
            numZeros++;
            if (numZeros == 1) zeroIndex = i;
            else return prodArr; // More than one zero, all instances will be zero
        }
        else product *= arr[i];
    }

    //With 1 zero, the only entry with a product will be the one that excludes zero (zeroIndex)
    if (numZeros == 1)
    {
        prodArr[zeroIndex] = product;
        return prodArr;
    }

    //Divides total product by each individual entry to populate product array
    for (int i = 0; i < arr.Length; i++)
    {
        prodArr[i] = product / arr[i];
    }
    return prodArr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    foreach(int i in arr) { Console.Write($"{i} "); }
    Console.WriteLine("]");
}