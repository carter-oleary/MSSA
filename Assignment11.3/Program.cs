namespace Assignment11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Assignment 11.3.1----");
            int[] arr1 = { 40, 10, 20, 30 };
            int[] arr2 = { 100, 100, 100 };
            int[] arr3 = [37, 12, 28, 9, 100, 56, 80, 5, 12];
            Console.WriteLine($"Original Array: [ {string.Join(", ", arr1)} ]");
            Console.WriteLine($"Rank Transform: [ {string.Join(", ", ArrayRankTransform(arr1))} ]");
            Console.WriteLine($"Original Array: [ {string.Join(", ", arr2)} ]");
            Console.WriteLine($"Rank Transform: [ {string.Join(", ", ArrayRankTransform(arr2))} ]");
            Console.WriteLine($"Original Array: [ {string.Join(", ", arr3)} ]");
            Console.WriteLine($"Rank Transform: [ {string.Join(", ", ArrayRankTransform(arr3))} ]");

            Console.WriteLine("\n----Assignment 11.3.2----");
            arr1 = [3, 2, 3];
            arr2 = [2, 2, 1, 1, 1, 2, 2];
            Console.WriteLine($"Array: [ {string.Join(", ", arr1)} ], Majority Element: {MajorityElement(arr1)}");
            Console.WriteLine($"Array: [ {string.Join(", ", arr2)} ], Majority Element: {MajorityElement(arr2)}");
        }

        public static int[] ArrayRankTransform(int[] arr)
        {
            var sortList = arr.ToHashSet<int>().ToList();
            sortList.Sort();
            int[] rankArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                rankArray[i] = sortList.BinarySearch(arr[i]) + 1; // +1 to convert to 1-based index
            }
            return rankArray;
        }

        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int num = 0;
            foreach(int n in nums)
            {
                if (count == 0)
                {
                    num = n;
                }
                count += (n == num) ? 1 : -1;
            }
            return num;
        }
    }
}
