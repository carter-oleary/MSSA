int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] arr2 = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };

Console.WriteLine("Initial Matrix: ");
PrintMatrix(arr1);
RotateMatrix(arr1);
Console.WriteLine("Rotated Matrix: ");
PrintMatrix(arr1);

Console.WriteLine("Initial Matrix: ");
PrintMatrix(arr2);
RotateMatrix(arr2);
Console.WriteLine("Rotated Matrix: ");
PrintMatrix(arr2);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine();
    }
}

void RotateMatrix(int[,] matrix)
{
    int temp = 0;
    int n = matrix.GetLength(0);
    // Rotate corners
    temp = matrix[0, 0]; // Store UL
    matrix[0, 0] = matrix[n - 1, 0]; // UL <= LL
    matrix[n - 1, 0] = matrix[n - 1, n - 1]; // LL <= LR
    matrix[n - 1, n - 1] = matrix[0, n - 1]; // LR <= UR
    matrix[0, n - 1] = temp; // UR <= UL


    // Rotates sides and diagonals
    for(int i = 0; i < n/2; i++)
    {
        for(int j = 1; j < n - 1; j++)
        {
            if(j >= i && j != i)
            {
                temp = matrix[i, j]; // Store upper
                matrix[i, j] = matrix[n - 1 - j, i]; // Upper <= Left
                matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j]; // Left <= Lower
                matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i]; // Lower <= Right
                matrix[j, n - 1 - i] = temp; // Right <= Upper
            }         
        }
    }
}