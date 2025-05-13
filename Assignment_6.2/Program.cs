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
    Array.Fill(prodArr, 1);

    int lProd = 1;
    int rProd = 1;
    for(int i = 0; i < arr.Length; i++)
    {
        prodArr[i] = lProd;
        lProd *= arr[i];
    }

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        prodArr[i] *= rProd;
        rProd *= arr[i];
    }

    return prodArr;


}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    foreach(int i in arr) { Console.Write($"{i} "); }
    Console.WriteLine("]");
}