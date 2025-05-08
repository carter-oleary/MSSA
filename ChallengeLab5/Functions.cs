public static class Functions
{
    public static int FindUnique(int[] numbers)
    {
        List<int> list = new List<int>();
        foreach (int number in numbers)
        {
            if (list.Contains(number))
            {
                list.Remove(number);
            }
            else
            {
                list.Add(number);
            }
        }
        return list[0];
    }

    public static int FindMissingNumber(int[] numbers)
    {
        Array.Sort(numbers);
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (mid == numbers.Length - 1) break;
            if (numbers[mid] == mid && numbers[mid + 1] != mid + 1) return mid + 1;
            else if(numbers[mid] == mid) left = mid + 1;
            else right = mid - 1;
        }
        return numbers.Length;
    }
}