namespace  ChallengeLab5;

public static class Functions
{
    public static int FindUnique(int[] arr)
    {
        List<int> list = new List<int>();
        foreach (int i in arr)
        {
            if(list.Contains(i)) list.Remove(i);
            else list.Add(i);
        }

        return list[0];
    }

    public static int FindMissingNumber(int[] arr)
    {
        Array.Sort(arr);
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == mid && arr[mid + 1] != mid + 1) return mid + 1;
            else if (arr[mid] == mid) left = mid + 1;
            else right = mid - 1;
        }

        return arr.Length;
    }
}