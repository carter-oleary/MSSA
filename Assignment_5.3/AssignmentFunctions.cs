public static class AssignmentFunctions
{
    public static bool Flowerbed(int[] flowerbed, int n)
    {
        int possFlowers = 0;
        if (flowerbed.Length == 1) return flowerbed[0] == 0 || n == 0;

        for (int i = 0; i < flowerbed.Length - 1; i++)
        {
            if (flowerbed[i] == 0)
            {
                if (i == 0 && flowerbed[1] == 0)
                {
                    flowerbed[0] = 1;
                    possFlowers++;
                }
                else if (i == flowerbed.Length - 2 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i + 1] = 1;
                    possFlowers++;
                }
                else if (i != 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    possFlowers++;
                }
            }
        }

        return possFlowers >= n;
    }

    public static int ClimbStairs(int n)
    {
        if (n == 1) return 1;

        int[] arr = new int[n + 1];
        arr[0] = 1;
        arr[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        return arr[n];
    }
}

