public static class Functions
{
    // Displays individual digit of a number using recursion
    public static void DisplayDigitsRec(int n)
    {
        if (n == 0) return;
        DisplayDigitsRec(n / 10);
        Console.Write($"{n % 10} ");
    }

    // Finds the sums of the right diagonals of a matrix
    public static int SumDiagonals(int[,] matrix)
    {
        int sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
        return sum;
    }

    // Builds a 2D Square matrix of size n
    public static int[,] BuildMatrix(int n)
    {
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Element [{i}, {j}]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return arr;
    }

    // Prints a provided 2D matrix
    public static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("The matrix is: ");
        for (int i = 0;i < matrix.GetLength(0); i++)
        {
            for (int j = 0;j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}